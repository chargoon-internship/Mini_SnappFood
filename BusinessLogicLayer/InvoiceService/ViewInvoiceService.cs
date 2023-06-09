using DataAccessLayes;
using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.InvoiceService
{
    public class ViewInvoiceService
    {
        public List<Invoice> PrintRestaurantInvoices(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.InvoiceRepository.GetRestaurantInvoices(id);
            }
        }

        public List<Invoice> PrintCustomerInvoices(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.InvoiceRepository.GetCustomerInvoice(id);
            }
        }

        public Invoice GetInvoiceById(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.InvoiceRepository.GetInvoiceById(id);
            }
        }

        public List<InvoicesFood> GetInvoicesFoodById(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.InvoiceRepository.GetInvoicesFoodById(id);
            }
        }

        public DataTable MyTable(int id)
        {
            Invoice invoice = GetInvoiceById(id);
            foreach (var item in invoice.Foods)
            {
                foreach (var x in GetInvoicesFoodById(id))
                {
                    item.Quantity = x.Quantity;
                }
            }
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");
            foreach (var item in invoice.Foods)
            {

                dataTable.Rows.Add(item.Name, item.Quantity, item.Price);

            }
            return dataTable;
        }
    }
}

