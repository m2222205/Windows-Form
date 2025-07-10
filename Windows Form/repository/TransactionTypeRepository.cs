using System.Data.SqlClient;
using System.Data;
using Windows_Form.Models;
using System.Drawing.Text;

namespace Windows_Form.repository
{
    public class TransactionTypeRepository
    {
        private DataBase db = new DataBase();
        public List<TransactionType> GetAllTransactionTypes()
        {
            
            List<TransactionType> list = new List<TransactionType>();

            SqlConnection conn = db.getConnection(); 

            try
            {
                using (SqlCommand cmd = new SqlCommand("GetAllTransactionTypes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    db.OpenConnection(); 

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new TransactionType
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        });
                    }

                    reader.Close(); 
                }
            }
            finally
            {
                db.CloseConnection(); 
            }

            return list;
        }

    }
}
















