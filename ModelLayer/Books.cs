﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer
{
  public  class Books
    {
        [Key]
        public int BookID { get; set; }
        [Required(ErrorMessage = "Please Enter Valid Book Name")]
        public string BookName { get; set; }
        public string BookDiscription { get; set; }
        [Required(ErrorMessage = "Please Enter Valid Price")]
        public string BookPrice { get; set; }
        [Required(ErrorMessage = "Please Enter Valid Author Name")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Please Enter Valid Quantity")]
        public string Quantity { get; set; }
        [Required]
        public string BookImage { get; set; }

    }
}
