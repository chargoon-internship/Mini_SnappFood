﻿using System;
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
        private DB db;

        public InvoiceRepository(DB db)
        {
            this.db = db;
        }

        public List<Invoice> GetOrders() => db.Invoices.ToList();
    }
}
