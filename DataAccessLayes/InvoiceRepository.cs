using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayes
{
    public class InvoiceRepository
    {
        private DB _db;

        public InvoiceRepository(DB db)
        {
            _db = db;
        }

        public List<Invoice> GetOrders() => _db.Invoices.ToList();

    }
}
