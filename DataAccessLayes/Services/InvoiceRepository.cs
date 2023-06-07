using DataAccessLayes.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes.Services
{
    public class InvoiceRepository:GenericRepository<Invoice>
    {
        private DB db;

        public InvoiceRepository(DB db):base(db) 
        {
            this.db = db;
        }

        public List<Invoice> GetRestaurantInvoices(int id)
        {
            return db.Invoices.Include(n => n.Restaurant.Foods).Where(n => n.Restaurant_Id == id).ToList();
        }

        public List<Invoice> GetCustomerInvoice(int id)
        {
            return db.Invoices.Include(n => n.Restaurant.Foods).Where(n => n.Customer_Id == id).ToList();
        }
    }
}
