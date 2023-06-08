﻿using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InvoiceService
{
    public class ViewInvoiceService
    {
        UnitOfWork db = new();

        public List<Invoice> PrintRestaurantInvoices(int id)
        {
            var invoices = db.InvoiceRepository.GetRestaurantInvoices(id);
            return invoices;
        }

        public List<Invoice> PrintCustomerInvoices(int id)
        {
            var invoices = db.InvoiceRepository.GetCustomerInvoice(id);
            return invoices;
        }
    }
}
