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
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<InvoicesFood> InvoicesFoods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2019;Database=Snapp;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasOne(n => n.Restaurant).WithMany(n => n.Foods).HasForeignKey(n => n.Restaurant_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Invoice>().HasOne(n => n.Customer).WithMany(n => n.Invoices).HasForeignKey(n => n.Customer_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Invoice>().HasOne(n => n.Restaurant).WithMany(n => n.Invoices).HasForeignKey(n => n.Restaurant_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>().HasIndex(n => n.UserName).IsUnique(true);
            modelBuilder.Entity<InvoicesFood>().HasKey(n => n.Id);
            modelBuilder.Entity<Invoice>().HasMany(n => n.Foods).WithMany(n => n.Invoices).UsingEntity<InvoicesFood>().HasIndex(n => new {n.FoodId,n.InvoiceId}).IsUnique(true);

            #region DataSeed

            //User u = new User()
            //{
            //    Id = 1,
            //    FirstName = "Maryam",
            //    LastName = "Zarei",
            //    UserName = "Mz52",
            //    Password = "23456",
            //};

            //u.Customer = new Customer()
            //{
            //    Id = u.Id,
            //    NatioalCode = "0024140695",
            //    HomeAddress = "Iran, Tehran",
            //};

            //modelBuilder.Entity<User>().HasData(u);

            //User s = new User()
            //{
            //    Id = 2,
            //    FirstName = "Ali",
            //    LastName = "Bahadori",
            //    UserName = "ABahadori79",
            //    Password = "0024140697",
            //};

            //s.Customer = new Customer()
            //{
            //    Id = s.Id,
            //    NatioalCode = "0024140697",
            //    HomeAddress = "Iran, Tabriz",
            //};

            //modelBuilder.Entity<User>().HasData(s);

            //modelBuilder.Entity<Restaurant>().HasData(new Restaurant()
            //{
            //    Id = 3,
            //    NameOfRestaurant = "Fall",
            //    Address = "Iran, Yazd",
            //    BeginDate = new TimeSpan(1, 5, 36, 0),
            //    EndDate = new TimeSpan(2, 3, 3, 8),
            //});

            //modelBuilder.Entity<Restaurant>().HasData(new Restaurant()
            //{
            //    Id = 2,
            //    NameOfRestaurant = "Green",
            //    Address = "Iran, Shiraz",
            //    BeginDate = new TimeSpan(1, 5, 7, 2),
            //    EndDate = new TimeSpan(2, 4, 3, 0),
            //});

            //List<Food> foods = new List<Food>()
            //{
            //    new Food() { Id = 1,Price = 200, Exist=true, Name="Chicken Barbecue", Restaurant_Id = 1 },
            //    new Food() { Id = 2,Price = 300, Exist=true, Name="lasagna", Restaurant_Id = 1 },
            //};
            //Invoice invoice = new Invoice()
            //{
            //    Foods = foods,
            //    Number = "4",
            //    Description = "Please prepare soon",
            //    Time = new DateTime(2023, 4, 3),
            //    FinalPrice = 200,
            //    Customer_Id = 1,
            //    Restaurant_Id = 1,
            //};
            //modelBuilder.Entity<Food>().HasData(foods);


            //List<Food> f = new List<Food>()
            //{
            //    new Food() { Id = 3,Price = 400, Exist=true, Name="Chicken Barbecue", Restaurant_Id = 2 },
            //    new Food() { Id = 4,Price = 500, Exist=true, Name="lasagna", Restaurant_Id = 2 },
            //};
            //Invoice i = new Invoice()
            //{
            //    Foods = f,
            //    Number = "2",
            //    Description = "Please bring hot food",
            //    Time = new DateTime(2023, 4, 16),
            //    FinalPrice = 300,
            //    Customer_Id = 2,
            //    Restaurant_Id = 2,
            //};
            //modelBuilder.Entity<Food>().HasData(f);


            #endregion
        }
    }
}
