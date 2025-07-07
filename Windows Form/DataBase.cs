using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Windows_Form
{
    public class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-P1VG7P4\SQLEXPRESS; Initial Catalog=MoneyTracking; Integrated Security =True");

        public void OpenConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }


        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }


        public SqlConnection getConnection()
        {
            return sqlConnection;
        }


    }
}
