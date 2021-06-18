using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
   public class ResponseWishlist
    {
        public int WishListId { get; set; }
        public int BookID { get; set; }
        public int UserId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string BookPrice { get; set; }
        public string BookImage { get; set; }
        public int WishListQuantity { get; set; }
    }
}
