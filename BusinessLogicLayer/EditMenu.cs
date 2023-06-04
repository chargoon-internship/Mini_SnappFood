using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayes;
using Entities;
using ViewModel;
using ViewModel.Food;

namespace BusinessLogicLayer
{
    public class EditMenu
    {
        UnitOfWork db = new UnitOfWork();

        public List<FoodViewModel> PrintAllMenu(int id)
        {
            List<FoodViewModel> foodViewModels = new List<FoodViewModel>();
            var foods=db.FoodRepository.GetByRestaurantID(id);
            foreach (var food in foods)
            {
                foodViewModels.Add(new FoodViewModel
                {
                    Id=food.Id,
                    Exist = food.Exist,
                    Name=food.Name,
                    Price=food.Price
                });
            }
            return foodViewModels;
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
