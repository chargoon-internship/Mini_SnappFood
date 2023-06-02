using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Number { get; set; } = "";

        [StringLength(200)]
        public string Description { get; set; } = "";

        public DateTime Time { get; set; }

        public Double FinalPrice { get; set; }


        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }

        [ForeignKey("CartItem")]
        public int CartItem_Id { get; set; }

        [ForeignKey("Restaurant")]
        public int Restaurant_Id { get; set; }

        public Customer? Customer { get; set; }

        public CartItem? CartItem { get; set; }
        

        public Restaurant? Restaurant { get; set; }


    }
}
