using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
   public class CartResponse
    {
        public int UserId { get; set; }
        public int CartId { get; set; }
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookPrice { get; set; }
        public string AuthorName { get; set; }
        public string BookImage { get; set; }
        public int TotalQuantity { get; set; }
    }
}
