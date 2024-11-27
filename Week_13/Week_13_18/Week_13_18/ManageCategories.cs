using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_13_18
{
    public record Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
    class ManageCategories
    {
        SqlConnection? connection;
        SqlCommand? command;
        string connectionString = "Data Source=TNN-HIU-LEGION-;Initial Catalog=MyStore;Persist Security Info=True;User ID=tnnh;Password=10012003;TrustServerCertificate=True";
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Categories";
            command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            CategoryId = reader.GetInt32("CategoryId"),
                            CategoryName = reader.GetString("CategoryName")
                        }
                        );
                    }
                }
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return categories;
        }


        public void InsertCategory(Category category)
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand("INSERT INTO Categories(CategoryName) VALUES(@CategoryName)", connection);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateCategory(Category category)
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand("UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryId = @CategoryId", connection);
            command.Parameters.AddWithValue("@CategoryId", category.CategoryId);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteCategory(Category category)
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand("DELETE FROM Categories WHERE CategoryId = @CategoryId", connection);
            command.Parameters.AddWithValue("@CategoryId", category.CategoryId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}