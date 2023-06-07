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
        UnitOfWork db = new();

        public List<Invoice> PrintRestaurantInvoices(int id)
        {
            var invoices = db.InvoiceRepository.GetOrders();
            return invoices.Where(i => i.Restaurant_Id == id).ToList();
        }

        public List<Invoice> PrintCustomerInvoices(int id)
        {
            var invoices = db.InvoiceRepository.GetInvoicesRestaurant(id);
            return invoices;
        }



        

        //public List<Invoice> PrintCustomerInvoices(int id)
        //{
        //    var invoices = db.InvoiceRepository.GetOrders();
        //    return invoices.Where(i => i.Customer_Id == id).ToList();
        //}

        //public List<Invoice> PrintCustomerInvoices(int id)
        //{
        //    var invoices = db.InvoiceRepository.GetOrders();
        //    return invoices.Include(f => f.Foods).Where(i => i.Customer_Id == id).ToList();
        //}

    }
}

