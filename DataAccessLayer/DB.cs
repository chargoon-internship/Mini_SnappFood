using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DB:DbContext
    {
        public DB():base("connect")
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Restaurant> Restaurants { get; set;}

        public DbSet<User> Users { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().HasRequired(n => n.User).WithOptional(n => n.Customer);
            //modelBuilder.Entity<Restaurant>().HasRequired(n => n.User).WithOptional(n => n.Restaurant);
        }

    }
}
