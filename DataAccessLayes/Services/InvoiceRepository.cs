using DataAccessLayes.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes.Services
{
    public class InvoiceRepository : GenericRepository<Invoice>
    {
        private DB db;

        public InvoiceRepository(DB db) : base(db)
        {
            this.db = db;
        }


        public bool Create(Invoice entity, List<Food> foods)
        {
            try
            {
                if (base.Insert(entity))
                {
                    foreach (Food food in foods)
                    {
                        InvoicesFood invoicesFood = new InvoicesFood();
                        invoicesFood.FoodId = food.Id;
                        invoicesFood.InvoiceId = entity.Id;
                        invoicesFood.Quantity=food.Quantity;
                        db.InvoicesFoods.Add(invoicesFood);
                    }
                    Save();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Invoice> GetRestaurantInvoices(int id)
        {
            var query = from i in db.Invoices
                        join x in db.InvoicesFoods on i.Id equals x.InvoiceId
                        select new Invoice()
                        {
                            Id = i.Id,
                            Number = i.Number,
                            Description = i.Description,
                            Customer_Id = i.Customer_Id,
                            Restaurant_Id = i.Restaurant_Id,
                            FinalPrice = i.FinalPrice,
                            Time = i.Time,
                            Foods = i.Foods,
                            Customer=i.Customer,
                            Restaurant=i.Restaurant,
                        };
            return query.Where(n => n.Restaurant_Id == id).ToList();
        }

        public List<InvoicesFood> invoicesFoodsById(int id)
        {
            var result = db.Invoices.Where(n => n.Restaurant_Id == id);
            var query = from i in db.InvoicesFoods
                        join x in result on i.InvoiceId equals x.Id
                        select new InvoicesFood()
                        {
                            Id = i.Id,
                            InvoiceId = i.InvoiceId,
                            Quantity = i.Quantity
                        };
            return query.ToList();
        }

        public List<Invoice> GetCustomerInvoice(int id)
        {
            var query = from i in db.Invoices
                        join x in db.InvoicesFoods on i.Id equals x.InvoiceId
                        select new Invoice()
                        {
                            Id = i.Id,
                            Number = i.Number,
                            Description = i.Description,
                            Customer_Id = i.Customer_Id,
                            Restaurant_Id = i.Restaurant_Id,
                            FinalPrice = i.FinalPrice,
                            Time = i.Time,
                            Foods = i.Foods,
                        };
            return query.Where(n => n.Customer_Id == id).ToList();
        }
    }
}
