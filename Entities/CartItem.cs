using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CartItem
    {
        public CartItem()
        {
            Foods= new List<Food>();
        }
        public int Id { get; set; }

        public Double TotalPrice { get; set; }

        public List<Food> Foods { get; set; }

        //quantity  

        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }

        public Customer? Customer { get; set; }

        public Double GetTotal()
        {
            Double result = 0;

            foreach (var item in Foods)
            {
                result += item.Price;
            }
            return result;
        }
    }
}
