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
   public class CartRepo :ICartRepo
    {
        private SqlConnection connection;
        private readonly IConfiguration configuration;
        string connectionString = null;
        //To Handle connection related activities
        public CartRepo(IConfiguration configuration)
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
        public List<CartResponse> GetAllCart()
        {
            try
            {
                Connection();
                List<CartResponse> cartlist = new List<CartResponse>();
                SqlCommand com = new SqlCommand("spGetAllCart", connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@UserId", 1);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                connection.Open();
                da.Fill(dt);
                //Bind CartModel generic list using dataRow     
                foreach (DataRow dr in dt.Rows)
                {
                    cartlist.Add(
                        new CartResponse
                        {
                            CartId = Convert.ToInt32(dr["CartId"]),
                            //UserId = Convert.ToInt32(dr["UserId"]),
                            BookID = Convert.ToInt32(dr["BookID"]),
                            BookName = Convert.ToString(dr["BookName"]),
                            BookPrice = Convert.ToString(dr["BookPrice"]),
                            AuthorName = Convert.ToString(dr["AuthorName"]),
                            BookImage = Convert.ToString(dr["BookImage"]),
                            TotalQuantity = Convert.ToInt32(dr["TotalQuantity"])

                        });
                }
                return cartlist;
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
