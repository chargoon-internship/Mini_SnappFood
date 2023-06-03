using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes
{
    public class DB : DbContext
    {
        private object _db;

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Food> Foods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2019;Database=Snapp;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasOne(n => n.Restaurant).WithMany(n => n.Foods).HasForeignKey(n => n.Restaurant_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Invoice>().HasOne(n => n.Customer).WithMany(n => n.Invoices).HasForeignKey(n => n.Customer_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Invoice>().HasOne(n => n.Restaurant).WithMany(n => n.Invoices).HasForeignKey(n => n.Restaurant_Id).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
