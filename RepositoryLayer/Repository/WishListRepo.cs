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
   public class WishListRepo : IWishListRepo
    {
        private SqlConnection connection;
        private readonly IConfiguration configuration;
        string connectionString = null;
        //To Handle connection related activities
        public WishListRepo(IConfiguration configuration)
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
        public List<ResponseWishlist> ViewWishListDetails()
        {
            try
            {
                Connection();
                List<ResponseWishlist> wishlist = new List<ResponseWishlist>();
                SqlCommand com = new SqlCommand("spGetAllWishList", connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@UserId", 1);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                connection.Open();
                da.Fill(dt);
                //Bind WistList generic list using dataRow     
                foreach (DataRow dr in dt.Rows)
                {
                    wishlist.Add(
                        new ResponseWishlist
                        {
                            UserId = Convert.ToInt32(dr["UserId"]),
                            // WishListId = Convert.ToInt32(dr["WishListId"]),
                            BookID = Convert.ToInt32(dr["BookID"]),
                            BookName = Convert.ToString(dr["BookName"]),
                            BookPrice = Convert.ToString(dr["Price"]),
                            WishListQuantity = Convert.ToInt32(dr["WishListQuantity"])
                        });
                }
                return wishlist;
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
