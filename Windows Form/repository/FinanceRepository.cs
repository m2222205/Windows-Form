using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form.Models;

namespace Windows_Form.repository
{
    public class FinanceRepository
    {
        private DataBase db = new DataBase();
        public int Add(Finance finance)
        {
            SqlConnection conn = db.getConnection();

            using (SqlCommand cmd = new SqlCommand("AddFinance", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Входные параметры
                cmd.Parameters.AddWithValue("@Доход", finance.Доход);
                cmd.Parameters.AddWithValue("@Расход", finance.Расход);
                cmd.Parameters.AddWithValue("@Кредит", finance.Кредит);
                cmd.Parameters.AddWithValue("@Дебит", finance.Дебит);
                cmd.Parameters.AddWithValue("@Зарплата", finance.Зарплата);
                cmd.Parameters.AddWithValue("@CategoryId", finance.CategoryId);

                // Выходной параметр для ID
                SqlParameter outputId = new SqlParameter("@NewId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                db.OpenConnection();
                cmd.ExecuteNonQuery();
                db.CloseConnection();

                return (int)outputId.Value; // Возвращаем ID новой записи
            }
        }



        public void Update(Finance finance)
        {
           SqlConnection conn = db.getConnection();
                using (SqlCommand cmd = new SqlCommand("UpdateFinance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", finance.ID); // Обязательно ID!
                    cmd.Parameters.AddWithValue("@Доход", finance.Доход);
                    cmd.Parameters.AddWithValue("@Расход", finance.Расход);
                    cmd.Parameters.AddWithValue("@Кредит", finance.Кредит);
                    cmd.Parameters.AddWithValue("@Дебит", finance.Дебит);
                    cmd.Parameters.AddWithValue("@Зарплата", finance.Зарплата);
                    cmd.Parameters.AddWithValue("@CategoryId", finance.CategoryId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            
        }

        public void Delete(int id)
        {
            SqlConnection conn = db.getConnection();
                using (SqlCommand cmd = new SqlCommand("DeleteFinance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }            
        }


        public List<Finance> GetAll()
        {
            List<Finance> list = new List<Finance>();

            SqlConnection conn = db.getConnection();
            using (SqlCommand cmd = new SqlCommand("GetAllFinanceWithCategory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Finance
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Доход = Convert.ToDecimal(reader["Доход"]),
                            Расход = Convert.ToDecimal(reader["Расход"]),
                            Кредит = Convert.ToDecimal(reader["Кредит"]),
                            Дебит = Convert.ToDecimal(reader["Дебит"]),
                            Зарплата = Convert.ToDecimal(reader["Зарплата"]),
                            Categories = new Category
                            {
                                Name = reader["CategoryName"].ToString()
                            }
                        });
                    }
                }
            
            return list;
        }






    }
}
