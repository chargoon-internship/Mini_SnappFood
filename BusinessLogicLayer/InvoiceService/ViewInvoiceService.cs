using DataAccessLayes;
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
        public List<Invoice> PrintRestaurantInvoices(int id)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var invoices = db.InvoiceRepository.GetRestaurantInvoices(id);
                return invoices;
            }

        }

        public List<Invoice> PrintCustomerInvoices(int id)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var invoices = db.InvoiceRepository.GetCustomerInvoice(id);
                return invoices;
            }
        }
    }
}

