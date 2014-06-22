using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

using MySql.Data.Common;
using MySql.Data.MySqlClient;


namespace DataFoundry.Core
{
    public partial class Database
    {
        public static MySqlConnection SQLConn = new MySqlConnection("SERVER=localhost;DATABASE=e_bekalan;UID=root;PASSWORD=");


        public static DataSet GetDataset(string SQLQuery)
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(SQLQuery, SQLConn);
            DataSet sqlDataSet = new DataSet();
            sqlAdapter.Fill(sqlDataSet);

            return sqlDataSet;
        }

        public static DataRowCollection GetDataRows(string SQLQuery)
        {
            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(SQLQuery, SQLConn);
            DataSet sqlDataSet = new DataSet();
            sqlAdapter.Fill(sqlDataSet);

            return sqlDataSet.Tables[0].Rows;
        }
    }
}
