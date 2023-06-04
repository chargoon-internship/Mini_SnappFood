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
       //edit

        UnitOfWork db = new UnitOfWork();

        public List<Food> PrintAllMenu(int id)
        {
            return db.FoodRepository.GetByRestaurantID(id);
        }
        public void AddMenu(Food food)
        {
            db.FoodRepository.Insert(food);
            
        }
        public string UpdateMenu(Food food)
        {
            var result=db.FoodRepository.Update(food);
            string message=result ? "با موفقیت ویرایش شد":"غذا مورد نظر ویرایش نشد";
            return message;
        }
        public Food FindMenuById(int id)
        {
           return db.FoodRepository.GetById(id);
        }
        public string DeleteMenuById(int id)
        {
            var result= db.FoodRepository.Delete(id);
            string message = result ? "با موفقیت حذف شد" : "غذا مورد نظر حذف نشد";
            return message;
        }
    }
}
