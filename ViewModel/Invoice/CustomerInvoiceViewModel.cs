using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Invoice
{
    public class CustomerInvoiceViewModel
    {
        public int Number { get; set; }
        public DateTime Time { get; set; }
        public string Food { get; set; }

        public string Description { get; set; }

        public Double FinalPrice { get; set; }

    }
}
