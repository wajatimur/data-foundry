namespace DataFoundry
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TableLevel = new Telerik.WinControls.UI.GridViewTemplate();
            this.ResultGrid = new Telerik.WinControls.UI.RadGridView();
            this.AnalyzeBackWork = new System.ComponentModel.BackgroundWorker();
            this.MainSstrip = new System.Windows.Forms.StatusStrip();
            this.MainSstripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainSstripCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainSstripProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ResultTstrip = new System.Windows.Forms.ToolStrip();
            this.ResultTStripAnalyze = new System.Windows.Forms.ToolStripButton();
            this.ResultTStripStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ResultTStripExports = new System.Windows.Forms.ToolStripSplitButton();
            this.ResultTStripExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CtxMenuMainGrid = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.CtxMenuExportExcel = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TableLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.MainSstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ResultTstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLevel
            // 
            this.TableLevel.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TableName";
            gridViewTextBoxColumn1.HeaderText = "Table Name";
            gridViewTextBoxColumn1.Name = "TableName";
            gridViewTextBoxColumn2.FieldName = "DataCount";
            gridViewTextBoxColumn2.HeaderText = "Data Count";
            gridViewTextBoxColumn2.Name = "DataCount";
            this.TableLevel.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            // 
            // ResultGrid
            // 
            this.ResultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultGrid.Location = new System.Drawing.Point(3, 28);
            // 
            // ResultGrid
            // 
            this.ResultGrid.MasterTemplate.AllowColumnReorder = false;
            this.ResultGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn3.FieldName = "DataKeyValue";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Data Key";
            gridViewTextBoxColumn3.Name = "DataKey";
            gridViewTextBoxColumn3.Width = 211;
            gridViewTextBoxColumn4.FieldName = "DataLabelValue";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Data Label";
            gridViewTextBoxColumn4.Name = "DataLabel";
            gridViewTextBoxColumn4.Width = 211;
            gridViewTextBoxColumn5.FieldName = "TableCount";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Table Count";
            gridViewTextBoxColumn5.Name = "TableCount";
            gridViewTextBoxColumn5.Width = 105;
            this.ResultGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.ResultGrid.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.TableLevel});
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.ReadOnly = true;
            gridViewRelation1.ChildColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ChildColumnNames")));
            gridViewRelation1.ChildTemplate = this.TableLevel;
            gridViewRelation1.ParentColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ParentColumnNames")));
            gridViewRelation1.ParentTemplate = this.ResultGrid.MasterTemplate;
            gridViewRelation1.RelationName = "ParentChild";
            this.ResultGrid.Relations.AddRange(new Telerik.WinControls.UI.GridViewRelation[] {
            gridViewRelation1});
            this.ResultGrid.Size = new System.Drawing.Size(566, 265);
            this.ResultGrid.TabIndex = 1;
            this.ResultGrid.Text = "Result Grid View";
            this.ResultGrid.ThemeName = "ControlDefault";
            this.ResultGrid.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.ResultGrid_GroupSummaryEvaluate);
            this.ResultGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultGrid_MouseDown);
            // 
            // AnalyzeBackWork
            // 
            this.AnalyzeBackWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DataAnalyze);
            this.AnalyzeBackWork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.AnalyzeBackWork_ProgressChanged);
            this.AnalyzeBackWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AnalyzeBackWork_RunWorkerCompleted);
            // 
            // MainSstrip
            // 
            this.MainSstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainSstripLabel,
            this.MainSstripCurrent,
            this.MainSstripProgress});
            this.MainSstrip.Location = new System.Drawing.Point(0, 422);
            this.MainSstrip.Name = "MainSstrip";
            this.MainSstrip.Size = new System.Drawing.Size(580, 24);
            this.MainSstrip.TabIndex = 5;
            this.MainSstrip.Text = "Main Status";
            // 
            // MainSstripLabel
            // 
            this.MainSstripLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.MainSstripLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.MainSstripLabel.Name = "MainSstripLabel";
            this.MainSstripLabel.Size = new System.Drawing.Size(49, 19);
            this.MainSstripLabel.Text = "Ready..";
            this.MainSstripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainSstripCurrent
            // 
            this.MainSstripCurrent.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.MainSstripCurrent.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.MainSstripCurrent.Name = "MainSstripCurrent";
            this.MainSstripCurrent.Size = new System.Drawing.Size(314, 19);
            this.MainSstripCurrent.Spring = true;
            this.MainSstripCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainSstripProgress
            // 
            this.MainSstripProgress.Name = "MainSstripProgress";
            this.MainSstripProgress.Size = new System.Drawing.Size(200, 18);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(580, 100);
            this.radPanel1.TabIndex = 6;
            this.radPanel1.Text = "<html><span>Data Foundry</span><span></span></html>";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radPanel1.ThemeName = "ControlDefault";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 322);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ResultGrid);
            this.tabPage1.Controls.Add(this.ResultTstrip);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResultTstrip
            // 
            this.ResultTstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResultTStripAnalyze,
            this.ResultTStripStop,
            this.toolStripSeparator1,
            this.ResultTStripExports});
            this.ResultTstrip.Location = new System.Drawing.Point(3, 3);
            this.ResultTstrip.Name = "ResultTstrip";
            this.ResultTstrip.Size = new System.Drawing.Size(566, 25);
            this.ResultTstrip.TabIndex = 0;
            this.ResultTstrip.Text = "ResultTstrip";
            // 
            // ResultTStripAnalyze
            // 
            this.ResultTStripAnalyze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResultTStripAnalyze.Image = ((System.Drawing.Image)(resources.GetObject("ResultTStripAnalyze.Image")));
            this.ResultTStripAnalyze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResultTStripAnalyze.Name = "ResultTStripAnalyze";
            this.ResultTStripAnalyze.Size = new System.Drawing.Size(52, 22);
            this.ResultTStripAnalyze.Text = "Analyze";
            this.ResultTStripAnalyze.Click += new System.EventHandler(this.ResultTStripAnalyze_Click);
            // 
            // ResultTStripStop
            // 
            this.ResultTStripStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResultTStripStop.Image = ((System.Drawing.Image)(resources.GetObject("ResultTStripStop.Image")));
            this.ResultTStripStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResultTStripStop.Name = "ResultTStripStop";
            this.ResultTStripStop.Size = new System.Drawing.Size(35, 22);
            this.ResultTStripStop.Text = "Stop";
            this.ResultTStripStop.Click += new System.EventHandler(this.ResultTStripStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ResultTStripExports
            // 
            this.ResultTStripExports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResultTStripExports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResultTStripExportExcel});
            this.ResultTStripExports.Image = ((System.Drawing.Image)(resources.GetObject("ResultTStripExports.Image")));
            this.ResultTStripExports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResultTStripExports.Name = "ResultTStripExports";
            this.ResultTStripExports.Size = new System.Drawing.Size(91, 22);
            this.ResultTStripExports.Text = "Export Result";
            // 
            // ResultTStripExportExcel
            // 
            this.ResultTStripExportExcel.Name = "ResultTStripExportExcel";
            this.ResultTStripExportExcel.Size = new System.Drawing.Size(121, 22);
            this.ResultTStripExportExcel.Text = "Excel File";
            this.ResultTStripExportExcel.Click += new System.EventHandler(this.ResultTStripExportExcel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CtxMenuMainGrid
            // 
            this.CtxMenuMainGrid.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.CtxMenuExportExcel});
            // 
            // CtxMenuExportExcel
            // 
            this.CtxMenuExportExcel.AccessibleDescription = "Export Group to Excel";
            this.CtxMenuExportExcel.AccessibleName = "Export Group to Excel";
            this.CtxMenuExportExcel.Name = "CtxMenuExportExcel";
            this.CtxMenuExportExcel.Text = "Export Group to Excel";
            this.CtxMenuExportExcel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.MainSstrip);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Foundry";
            ((System.ComponentModel.ISupportInitialize)(this.TableLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.MainSstrip.ResumeLayout(false);
            this.MainSstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResultTstrip.ResumeLayout(false);
            this.ResultTstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker AnalyzeBackWork;
        private System.Windows.Forms.StatusStrip MainSstrip;
        private System.Windows.Forms.ToolStripStatusLabel MainSstripLabel;
        private System.Windows.Forms.ToolStripProgressBar MainSstripProgress;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Telerik.WinControls.UI.RadGridView ResultGrid;
        private System.Windows.Forms.ToolStrip ResultTstrip;
        private System.Windows.Forms.ToolStripButton ResultTStripAnalyze;
        private System.Windows.Forms.TabPage tabPage2;
        private Telerik.WinControls.UI.GridViewTemplate TableLevel;
        private System.Windows.Forms.ToolStripButton ResultTStripStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton ResultTStripExports;
        private System.Windows.Forms.ToolStripMenuItem ResultTStripExportExcel;
        private System.Windows.Forms.ToolStripStatusLabel MainSstripCurrent;
        private Telerik.WinControls.UI.RadContextMenu CtxMenuMainGrid;
        private Telerik.WinControls.UI.RadMenuItem CtxMenuExportExcel;

    }
}

