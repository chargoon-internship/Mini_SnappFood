using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ViewInvoice
    {
        UnitOfWork db = new();

        public List<Invoice> PrintInvoices(int id)
        {
            var invoices = db.InvoiceRepository.GetOrders();
            return invoices.Where(i => i.Restaurant_Id == id).ToList();
        }


        //public List<Invoice> PrintCustomerInvoices(IList result)
        //{

            //var invoices = db.InvoiceRepository.GetOrders(includeProperties: "Foods");

            //var result = from invoice in invoices
            //             from food in invoice.Foods
            //             select new
            //             {
            //                 CartItemId = invoice.Id,
            //                 Time = invoice.Date,
            //                 FoodName = food.Name,
            //                 Price = food.Price,
            //                 FinalPrice = invoice.Total + food.Price
            //             };
            //return result;

            //dataGridView1.DataSource = result.ToList();
        //}
    }
}

