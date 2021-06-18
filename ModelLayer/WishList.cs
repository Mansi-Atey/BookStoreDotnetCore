using System;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public class WishList
    {

        [Key]
        [Required]
        public int WishListId { get; set; }
        public int UserId { get; set; }
        public int BookID { get; set; }
        public string Price { get; set; }
        public string BookName { get; set; }
        public int WishListQuantity { get; set; }
    }
}
