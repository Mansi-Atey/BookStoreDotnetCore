using Microsoft.Extensions.Configuration;
using ModelLayer;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.Repository
{
    public class BookRepo : IBookRepo
    {
        private SqlConnection connection;
        private readonly IConfiguration configuration;
        string connectionString = null;
        //To Handle connection related activities
        public BookRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        private void Connection()
        {
            try
            {

                connectionString = configuration.GetSection("ConnectionStrings").GetSection("ConnectionString").Value;
                connection = new SqlConnection(connectionString);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
        public List<Books> GetAllBooks()
        {
            try
            {
                Connection();
                List<Books> booklist = new List<Books>();
                SqlCommand com = new SqlCommand("spGetAllBooks", connection);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                connection.Open();
                da.Fill(dt);
                //Bind bookModel generic list using dataRow     
                foreach (DataRow dr in dt.Rows)
                {
                    booklist.Add(
                        new Books
                        {

                            BookID = Convert.ToInt32(dr["BookID"]),
                            BookName = Convert.ToString(dr["BookName"]),
                            BookDiscription = Convert.ToString(dr["BookDiscription"]),
                            BookPrice = Convert.ToString(dr["BookPrice"]),
                            AuthorName = Convert.ToString(dr["AuthorName"]),
                            BookImage = Convert.ToString(dr["BookImage"]),
                            Quantity = Convert.ToString(dr["Quantity"])
                        });
                }
                return booklist;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}