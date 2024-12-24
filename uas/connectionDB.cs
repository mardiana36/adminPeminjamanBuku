using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projectVisual
{
    internal class connectionDB
    {
        private string _connectionString;
        public SqlConnection connDB;

        public connectionDB()
        {
            _connectionString = @"DATA SOURCE=.;" +
                                "INITIAL CATALOG=dbBA224;" +
                                //"USER ID=;" +
                                //"PASSWORD=;" +
                                "Connect Timeout=120;" +
                                "INTEGRATED SECURITY=TRUE;" +
                                "LOAD BALANCE TIMEOUT=0;";
            connDB = new SqlConnection(_connectionString);

            try
            {
                connDB.Open();
                if (connDB.State != ConnectionState.Open)
                {
                    MessageBox.Show("Database tidak bisa dibuka !");
                    connDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error di = " + ex.Message);
                connDB.Close();
            }
        }
    }
}
