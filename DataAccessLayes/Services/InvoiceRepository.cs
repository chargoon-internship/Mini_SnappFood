using DataAccessLayes.Repositories;
using Entities;
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

        public List<Invoice> GetOrders() => db.Invoices.ToList();
    }
}
