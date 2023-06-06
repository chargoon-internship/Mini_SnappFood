using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CartItem
    {
        public int RestaurantId { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public List<Entities.Food>? Foods { get; set; }

        public double GetPrice()
        {
            double price = 0;
            if (Foods != null)
            {
                foreach (var item in Foods)
                {
                    price += (item.Price * item.Quantity);
                }
            }
            return price;
        }

    }


}
