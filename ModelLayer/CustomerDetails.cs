using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer
{
  public  class CustomerDetails
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        [Key]
        public int CustomerId { get; set; }
        public string Pincode { get; set; }
        public string PhoneNumber { get; set; }
        public string Locality { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Landmark { get; set; }
        public string Type { get; set; }
    }
}
