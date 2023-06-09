using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.FoodService
{
    public class BuyFoodService
    {
        public IEnumerable<Food> GetFoods(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.FoodRepository.GetByRestaurantID(id);
            }
        }

        public Restaurant GetRestaurantById(int id)
        {
            using(UnitOfWork db=new UnitOfWork())
            {
                return db.RestaurantRepository.GetById(id);
            }
        }

        public bool Create(Invoice invoice,List<Food> foods)
        {
            Random random=new Random();
            invoice.Number = random.Next(1000000).ToString();
            using (UnitOfWork db=new UnitOfWork())
            {
                return db.InvoiceRepository.Create(invoice, foods);
            }
        }
    }
}
