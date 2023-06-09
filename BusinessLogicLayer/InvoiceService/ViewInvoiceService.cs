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
            List<Invoice> invoices;
            List<InvoicesFood> invoicesFood;
            using (UnitOfWork db=new UnitOfWork())
            {
                invoices = db.InvoiceRepository.GetRestaurantInvoices(id);
                invoicesFood = db.InvoiceRepository.invoicesFoodsById(id);
            }
            foreach (var item in invoices)
            {
                foreach (var x in item.Foods)
                {
                    foreach (var v in invoicesFood)
                    {
                        x.Quantity = v.Quantity;
                    }
                }
            }
            return invoices;
        }
    }
}

