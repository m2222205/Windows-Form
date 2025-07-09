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

                cmd.Parameters.AddWithValue("@Amount", finance.Amount);
                cmd.Parameters.AddWithValue("@TypeId", finance.TypeId);
                cmd.Parameters.AddWithValue("@Date", finance.Date);
                cmd.Parameters.AddWithValue("@SalaryPercent", finance.SalaryPercent);
                cmd.Parameters.AddWithValue("@BalanceAfter", finance.BalanceAfter);
                cmd.Parameters.AddWithValue("@IsCredit", finance.IsCredit);
                cmd.Parameters.AddWithValue("@IsDebit", finance.IsDebit);
                cmd.Parameters.AddWithValue("@CategoryId", finance.CategoryId);

                SqlParameter outputId = new SqlParameter("@NewId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                db.OpenConnection();
                cmd.ExecuteNonQuery();
                db.CloseConnection();

                return (int)outputId.Value;
            }
        }



        public void Update(Finance finance)
        {
            SqlConnection conn = db.getConnection();
            using (SqlCommand cmd = new SqlCommand("UpdateFinance", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", finance.ID);
                cmd.Parameters.AddWithValue("@Amount", finance.Amount);
                cmd.Parameters.AddWithValue("@TypeId", finance.TypeId);
                cmd.Parameters.AddWithValue("@Date", finance.Date);
                cmd.Parameters.AddWithValue("@SalaryPercent", finance.SalaryPercent);
                cmd.Parameters.AddWithValue("@BalanceAfter", finance.BalanceAfter);
                cmd.Parameters.AddWithValue("@IsCredit", finance.IsCredit);
                cmd.Parameters.AddWithValue("@IsDebit", finance.IsDebit);
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

            // Этот код (который вы мне предоставили) ДОЛЖЕН БЫТЬ ЗДЕСЬ
            SqlConnection conn = db.getConnection(); // Получаем соединение
            using (SqlCommand cmd = new SqlCommand("GetAllFinanceWithCategory", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlDataReader reader = null;
                try
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Finance
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Amount = Convert.ToDecimal(reader["Сумма"]), // Читаем по псевдониму "Сумма"

                            TransactionType = new TransactionType
                            {
                                Id = reader["_TypeId"] != DBNull.Value ? Convert.ToInt32(reader["_TypeId"]) : 0,
                                Name = reader["Тип Операции"] != DBNull.Value ? reader["Тип Операции"].ToString() : string.Empty
                            },
                            Categories = new Category
                            {
                                Id = reader["_CategoryId"] != DBNull.Value ? Convert.ToInt32(reader["_CategoryId"]) : 0,
                                Name = reader["Категория"] != DBNull.Value ? reader["Категория"].ToString() : string.Empty
                            },

                            Date = Convert.ToDateTime(reader["Дата"]),
                            SalaryPercent = reader["Процент Зарплаты"] != DBNull.Value ? Convert.ToDecimal(reader["Процент Зарплаты"]) : 0m,
                            BalanceAfter = reader["Баланс После"] != DBNull.Value ? Convert.ToDecimal(reader["Баланс После"]) : 0m,
                            IsCredit = Convert.ToBoolean(reader["Кредит"]),
                            IsDebit = Convert.ToBoolean(reader["Дебит"])
                        });
                    }
                }
                finally
                {
                    if (reader != null && !reader.IsClosed)
                    {
                        reader.Close();
                    }
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            return list;
        }




        public Finance GetById(int id)
        {
            Finance finance = null;
            SqlConnection conn = db.getConnection();

            using (SqlCommand cmd = new SqlCommand("GetFinanceById", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    finance = new Finance
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Amount = Convert.ToDecimal(reader["Amount"]),
                        Date = Convert.ToDateTime(reader["Date"]),
                        SalaryPercent = Convert.ToDecimal(reader["SalaryPercent"]),
                        BalanceAfter = Convert.ToDecimal(reader["BalanceAfter"]),
                        IsCredit = Convert.ToBoolean(reader["IsCredit"]),
                        IsDebit = Convert.ToBoolean(reader["IsDebit"]),
                        TypeId = Convert.ToInt32(reader["TypeId"]),
                        CategoryId = Convert.ToInt32(reader["CategoryId"]),
                        TransactionType = new TransactionType
                        {
                            Id = Convert.ToInt32(reader["TypeId"]),
                            Name = reader["TransactionTypeName"].ToString()
                        },
                        Categories = new Category
                        {
                            Id = Convert.ToInt32(reader["CategoryId"]),
                            Name = reader["CategoryName"].ToString()
                        }
                    };
                }
            }

            return finance;
        }


        public List<TransactionType> GetTypes()
        {
            List<TransactionType> types = new List<TransactionType>();

            SqlConnection conn = db.getConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT Id, Name FROM TransactionType", conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    types.Add(new TransactionType
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString()
                    });
                }
            }

            return types;
        }



    }

}
