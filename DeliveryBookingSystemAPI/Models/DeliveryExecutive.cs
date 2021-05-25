using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingSystemAPI.Models
{
    public class DeliveryExecutive
    {
        [Key]
        public int executiveID { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string isVerified { get; set; }
    }
}
