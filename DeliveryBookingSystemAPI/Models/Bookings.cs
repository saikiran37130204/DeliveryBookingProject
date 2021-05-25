using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingSystemAPI.Models
{
    public class Bookings
    {
        [Key]
        public int orderID { get; set; }
        public int customerID { get; set; }
        public int executiveID { get; set; }
        public DateTime date { get; set; }
        public TimeSpan timeOfPickUp { get; set; }
        public float weight { get; set; }
        public float price { get; set; }
    }
}
