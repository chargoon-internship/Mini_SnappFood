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
        private DB dB;
        private object _db;

        public InvoiceRepository(DB dB)
        {
            this.dB = dB;
        }


        //public List<Invoice> GetOrders() => _db.Invoices.ToList();

    }
}
