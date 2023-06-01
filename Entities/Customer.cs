using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public Customer()
        {
            CartItems= new List<CartItem>();

            Invoices = new List<Invoice>();
        }
        [Key,ForeignKey("User")]
        public int Id { get; set; }

        public string NatioalCode { get; set; }

        [Required]
        public string HomeAddress { get; set; }

        public List<CartItem> CartItems { get; set; }

        public List<Invoice> Invoices { get; set; }

        public User User { get; set; }

    }
}
