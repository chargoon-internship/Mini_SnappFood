using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ViewModel.Rertaurant
{
    public class RestaurantViewModel
    {
        public string RestaurantName { get; set; }
/*
        public string RestaurantType { get; set; }

        public string RestaurantScore { get; set; }*/

        public string Address { get; set; }

        public override string ToString()
        {
            /*return $"{RestaurantName}({Address})\n ({RestaurantScore})\n{RestaurantType}";*/
            return $"{RestaurantName}({Address})\n";
        }
    }
}
