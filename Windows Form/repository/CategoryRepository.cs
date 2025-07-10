using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Form.Models;

namespace Windows_Form.repository
{
    public class CategoryRepository
    {
        private DataBase _db = new DataBase();

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            SqlConnection conn = _db.getConnection();

            using (SqlCommand command = new SqlCommand("GetCategories", conn)) 
            {
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    _db.OpenConnection();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new Category
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"Ошибка БД при получении категорий: {ex.Message}", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Неизвестная ошибка при получении категорий: {ex.Message}", ex);
                }
                finally
                {
                    _db.CloseConnection();
                }
            }
            return categories;
        }


    }
}
