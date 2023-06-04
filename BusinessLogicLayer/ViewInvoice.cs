using DataAccessLayes;
using Entities;

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

    }
}
