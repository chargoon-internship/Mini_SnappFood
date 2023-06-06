using DataAccessLayes.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes
{
    public class FoodRepository:GenericRepository<Food>
    {
        private DB _db;

        public FoodRepository(DB dB):base(dB)
        {
            _db = dB;
        }


        public bool IsExistFood(Food food,int Id)
        {
            var foods = GetByRestaurantID(Id);
            return foods.Any(f =>f.Name == food.Name);
        }
        public List<Food> GetByRestaurantID(int RestaurantID)
        {
            return _db.Foods.Where(f => f.Restaurant_Id == RestaurantID).ToList();
        }
        public bool IsExistUpdate(Food food, int Id)
        {
            var foods = GetByRestaurantID(Id);

            return foods.Any(f => f.Id != food.Id && f.Name == food.Name);

        }
        public bool Update(Food food)
        {
            var local = _db.Foods.FirstOrDefault(f => f.Id == food.Id);
            if (local != null)
            {

                local.Name = food.Name;
                local.Price = food.Price;
                local.Exist = food.Exist;

                _db.SaveChanges();

                return true;
            }
            return false;


        }
    }
}