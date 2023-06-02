using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayes;
using Entities;

namespace BusinessLogicLayer
{
    public class EditMenu
    {
        UnitOfWork db = new UnitOfWork();

        public List<Food> PrintAllMenu(int id)
        {
           var foods=db.FoodRepository.GetAll();
            return foods.Where(f=>f.Restaurant_Id==id).ToList();
        }
        public void AddMenu(Food food)
        {
            db.FoodRepository.Insert(food);
            
        }
        public void UpdateMenu(Food food)
        {
            db.FoodRepository.Update(food);
        }
        public Food FindMenuById(int id)
        {
           return db.FoodRepository.GetById(id);
        }
    }
}
