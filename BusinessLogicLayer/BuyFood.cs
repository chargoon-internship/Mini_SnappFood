using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BuyFood
    {
        public IEnumerable<Food> GetFoods(int id)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                return db.FoodRepository.GetByRestaurantID(id);
            }
        }
    }
}
