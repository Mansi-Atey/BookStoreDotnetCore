using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [Key]
        public int UserId { get; set; }
        [Key]
        public int BookID { get; set; }
        public int TotalQuantity { get; set; }
    }
}
