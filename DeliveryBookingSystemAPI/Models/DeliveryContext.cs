using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingSystemAPI.Models
{
    public class DeliveryContext:DbContext
    {
        public DeliveryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<DeliveryExecutive> deliveryExecutives { get; set; }
        public DbSet<Bookings> bookings { get; set; }
    }
}
