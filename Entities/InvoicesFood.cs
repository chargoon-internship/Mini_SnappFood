using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoicesFood
    {

        public int Id { get; set; }


        public int InvoiceId { get; set; }


        public int FoodId { get; set; }

        public Invoice? Invoice { get; set; }

        public Food? Food { get; set; }
    }
}
