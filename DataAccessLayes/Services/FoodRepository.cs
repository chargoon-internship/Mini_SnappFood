using DataAccessLayes.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes.Services
{
    public class FoodRepository:GenericRepository<Food>
    {
        private DB _db;

        public FoodRepository(DB dB):base(dB)
        {
            _db = dB;
        }


        public bool IsExistFood(string FoodName)
        {
            return _db.Foods.Any(f => f.Name == FoodName);
        }
        public List<Food> GetByRestaurantID(int RestaurantID)
        {
            return _db.Foods.Where(f => f.Restaurant_Id == RestaurantID).ToList();
        }
        public bool IsExistUpdate(Food food)
        {
            return _db.Foods.Any(f => f.Id != food.Id && f.Name == food.Name);

        }
    }
}
