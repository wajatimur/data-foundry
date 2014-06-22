using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DataFoundry.Core;
using DataFoundry.Core.Utility;

//using FluentNHibernate.Cfg;
//using FluentNHibernate.Cfg.Db; 
//using FluentNHibernate.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
//using NHibernate;
//using NHibernate.Cfg;
//using NHibernate.Linq;
using Telerik.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.UI.Export;


namespace DataFoundry
{
    

    public partial class FormMain : Form
    {
        public DataSet ResultGridDS = new DataSet();
        public List<string> MasterTables = new List<string>();
        public BindingList<SourceData> MasterLinkedData = new BindingList<SourceData>();
        private DateTime AnalyzeStartTime;
        SynchronizationContext BaseContext;

        public FormMain()
        {
            InitializeComponent();

            BaseContext = SynchronizationContext.Current;
            AnalyzeBackWork.WorkerReportsProgress = true;
            AnalyzeBackWork.WorkerSupportsCancellation = true;

            ResultGrid.DataSource = MasterLinkedData;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultTStripAnalyze_Click(object sender, EventArgs e)
        {
            if (AnalyzeBackWork.IsBusy != true)
            {
                AnalyzeStartTime = DateTime.Now;
                AnalyzeBackWork.RunWorkerAsync();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataAnalyze(object sender, DoWorkEventArgs e)
        {
            Dictionary<string, DataRowCollection> VirtualDataSet = new Dictionary<string, DataRowCollection>();
            BackgroundWorker worker = sender as BackgroundWorker;

            string[] DestKeyFieldsToSearch = { "NoDaftarSyarikat", "NoDaftarKilang", "NDS_Pengilang", "NDS_Pemborong" };
            string[] DestTableExclude = { "ref_syarikat", "ref_syarikat_profail" };

            string SourceTableName = "ref_syarikat_profail";
            string SourceKeyField = "NoDaftarSyarikat";
            string SourceLabelField = "NamaSyarikat";

            try
            {
                /*[i] Load master tables */
                string sqlQueryTables = "SHOW Tables IN e_bekalan";
                DataRowCollection DestTableRows = Database.GetDataRows(sqlQueryTables);

                foreach (DataRow DestTable in DestTableRows)
                {
                    string tableName = DestTable[0].ToString();
                    MasterTables.Add(tableName);
                }

                /*[i] Search for linked data */
                string sqlQuerySource = "SELECT " + SourceKeyField +"," + SourceLabelField + " FROM " + SourceTableName;
                DataRowCollection SourceDataRows = Database.GetDataRows(sqlQuerySource);
                int SourceDataCount = SourceDataRows.Count;
                int SourceDataIdx = 0;

                foreach (DataRow SourceData in SourceDataRows)
                {
                    if (e.Cancel) break;

                    string SourceKeyValue = SourceData[SourceKeyField].ToString().Trim();
                    string SourceLabelValue = SourceData[SourceLabelField].ToString().Trim();
                    SourceDataIdx++;

                    //[i] Add data to master link table
                    SourceData GetSourceData = new SourceData(SourceKeyValue, SourceLabelValue);
                    BaseContext.Send(delegate
                    {
                        MasterLinkedData.Add(GetSourceData);
                    }, null);

                    /*[i] Find in each tables */
                    foreach (string CurTableName in MasterTables)
                    {
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }

                        //[i] Skip is current table in exclude array, can be improve by pre-remove exlude table
                        if (DestTableExclude.Contains(CurTableName)) continue;

                        DataRowCollection DestDataRows;
                        int DestDataIdx = 0;
                        /*if (VirtualDataSet.ContainsKey(CurTableName))
                        {
                            DestDataRows = VirtualDataSet[CurTableName];
                        }
                        else
                        {*/
                            string sqlQuerySearchTable = "SELECT * FROM " + CurTableName;
                            DestDataRows = Database.GetDataRows(sqlQuerySearchTable);
                            VirtualDataSet[CurTableName] = DestDataRows;
                        //}
                        int DestDataCount = DestDataRows.Count;


                        /*[i] Search every destionation rows */
                        foreach (DataRow DestData in DestDataRows)
                        {
                            if (worker.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }

                            /*[i] Search every defined field */
                            foreach (string FieldName in DestKeyFieldsToSearch)
                            {
                                if (worker.CancellationPending)
                                {
                                    e.Cancel = true;
                                    break;
                                }

                                //[i] Get columne index by name
                                int FieldIndex = DestData.Table.Columns.IndexOf(FieldName);
                                
                                //[i] If column defined found..
                                if (FieldIndex > -1)
                                {
                                    //[i] Get field value from curent searched row
                                    string DestKeyValue = DestData[FieldIndex].ToString();

                                    //[i] If value is equal to source field value
                                    if (SourceKeyValue == DestKeyValue)
                                    {
                                        //[i] Exiting method due to async cancel
                                        if (e.Cancel) return;

                                        RelateTable CurrentTable = new RelateTable();
                                        CurrentTable.DataKeyValue = SourceKeyValue;
                                        CurrentTable.TableName = CurTableName;
                                        CurrentTable.DataCount = 1;

                                        //'[i] Check if data existed.
                                        RelateTable LinkedData = GetSourceData.Relations.Find(sr => sr.TableName == CurrentTable.TableName);
                                        if (LinkedData != null)
                                        {
                                            LinkedData.DataCount++;
                                            //Debug.WriteLine("Found exist : " + SourceKeyValue + " on table " + CurTableName + " : " + LinkedData.DataCount);
                                        }
                                        else
                                        {
                                            BaseContext.Send(delegate
                                            {
                                                GetSourceData.Relations.Add(CurrentTable);
                                                //Debug.WriteLine("Added : " + SourceKeyValue + " on table " + CurTableName);
                                            }, null);
                                        }


                                        //[i] Update status panel on current object
                                        BaseContext.Send(delegate
                                        {
                                            MainSstripCurrent.Text = String.Format("Data [{0}] Table [{1}] Field [{2}]", SourceKeyValue, CurrentTable.TableName, DestData.Table.Columns[FieldIndex].ColumnName);
                                        }, null);

                                        CurrentTable = null;
                                    }
                                }
                            }

                            //[i] Per row in every tables progress
                            DestDataIdx++;
                            worker.ReportProgress((DestDataIdx * 100) / DestDataCount, "table");
                        }
                    }

                    //[i] Total progress in percent
                    worker.ReportProgress((SourceDataIdx * 100) / SourceDataCount,"total");
                }


                /* Set the UPDATE command and parameters.
                sqlAdapter.UpdateCommand = new MySqlCommand("UPDATE items SET ItemName=@ItemName, Price=@Price, AvailableQuantity=@AvailableQuantity, Updated_Dt=NOW() WHERE ItemNumber=@ItemNumber;",sqlConn );
                sqlAdapter.UpdateCommand.Parameters.Add("@ItemNumber", MySqlDbType.Int16, 4, "ItemNumber");
                sqlAdapter.UpdateCommand.Parameters.Add("@ItemName", MySqlDbType.VarChar, 100, "ItemName");
                sqlAdapter.UpdateCommand.Parameters.Add("@Price", MySqlDbType.Decimal, 10, "Price");
                sqlAdapter.UpdateCommand.Parameters.Add("@AvailableQuantity", MySqlDbType.Int16, 11, "AvailableQuantity");
                sqlAdapter.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;
                
                //Delete a row from grid first.
                ResultGrid.Rows.Remove(ResultGrid.SelectedRows[0]);

                //Save records again. This will delete record from database.
                sqlAdapter.Update(sqlDataSet.Tables[0]);
                 
                */
            }
            finally
            {

            }
        }


        public class SourceData
        {
            public SourceData(string KeyValue, string LabelValue)
            {
                this.DataKeyValue = KeyValue;
                this.DataLabelValue = LabelValue;
                this.Relations = new List<RelateTable>();
            }

            public string DataKeyValue { get; set; }
            public string DataLabelValue { get; set; }
            public int TableCount { get { return this.Relations.Count; } }
            public List<RelateTable> Relations { get; set; }
        }


        public class RelateTable
        {
            public string DataKeyValue { get; set; }
            public string TableName { get; set; }
            public int DataCount { get; set; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnalyzeBackWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState.ToString() == "total")
            {
                MainSstripLabel.Text = String.Format("Total progress : {0} %", e.ProgressPercentage);
            }
            else if (e.UserState.ToString() == "table")
            {
                MainSstripProgress.Value  = e.ProgressPercentage;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnalyzeBackWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TimeSpan AnalyzeTimeElapse = DateTime.Now - AnalyzeStartTime;

            if (e.Cancelled == true)
            {
                MainSstripLabel.Text = "Progress stop by user!";
                MainSstripCurrent.Text = String.Format( "Total progress time : {0} Hours and {1} Minute ", (int)AnalyzeTimeElapse.TotalHours, AnalyzeTimeElapse.Minutes );
                MainSstripProgress.Value = 0;
            }
            else if (e.Error != null)
            {
                MainSstripLabel.Text = "Thread error! progress stopped";
            }
            else
            {
                MainSstripLabel.Text = "Progress complete!";
                MainSstripCurrent.Text = String.Format("Total progress time : {0} Hours and {1} Minute ", (int)AnalyzeTimeElapse.TotalHours, AnalyzeTimeElapse.Minutes);
                MainSstripProgress.Value = 0;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultTStripStop_Click(object sender, EventArgs e)
        {
            AnalyzeBackWork.CancelAsync();
        }

        private void ResultTStripExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcelML excelExporter = new ExportToExcelML(this.ResultGrid);
            //excelExporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            //excelExporter.SheetMaxRows = ExcelMaxRows._1048576;
            //excelExporter.SummariesExportOption = SummariesOption.DoNotExport;

            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "Excel|*.xlsx";
            saveFileDlg.DefaultExt = "xlsx";
            saveFileDlg.Title = "Select file to save";

            saveFileDlg.ShowDialog();

            if (saveFileDlg.FileName != "")
            {
                excelExporter.RunExport(saveFileDlg.FileName);
            }
        }

        private void ResultGrid_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.SummaryItem.Name == "TableCount")
            {
                int intCount = e.Group.ItemCount;
                e.FormatString = String.Format("Group : {0}. Members : {1}", e.Value,  intCount);
            }
        }


        private void ResultGrid_MouseDown(object sender, MouseEventArgs e)
        {
            GridViewChildRowCollection GetChildRows;

            if (e.Button == MouseButtons.Right)
            {
                GridGroupHeaderRowElement headerRowElement = this.GetGridGroupHeaderRowElement(e.Location);

                if (headerRowElement != null)
                {
                    GetChildRows = headerRowElement.RowInfo.ChildRows;
                    CtxMenuMainGrid.DropDown.Location = this.PointToScreen(e.Location);
                    CtxMenuMainGrid.Show();
                }
            }
        }


        private GridGroupHeaderRowElement GetGridGroupHeaderRowElement(Point location)
        {
            RadElement elementUnderMouse = this.ResultGrid.ElementTree.GetElementAtPoint(location);
            while (elementUnderMouse != null)
            {
                GridGroupHeaderRowElement headerRow = elementUnderMouse as GridGroupHeaderRowElement;

                if (headerRow != null)
                {
                    return headerRow;
                }
                elementUnderMouse = elementUnderMouse.Parent;
            }
            return null;
        }


    }
}
