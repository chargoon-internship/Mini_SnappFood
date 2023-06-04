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
        //edit



        public List<FoodViewModel> PrintAllMenu(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<FoodViewModel> foodViewModels = new List<FoodViewModel>();
                var foods = db.FoodRepository.GetByRestaurantID(id);
                foreach (var food in foods)
                {
                    foodViewModels.Add(new FoodViewModel
                    {
                        Id = food.Id,
                        Exist = food.Exist,
                        Name = food.Name,
                        Price = food.Price
                    });
                }
                return foodViewModels;
            }

        }
        public void AddMenu(Food food)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                db.FoodRepository.Insert(food);
            }
        }
        public string UpdateMenu(Food food)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var result = db.FoodRepository.Update(food);
                string message = result ? "با موفقیت ویرایش شد" : "غذا مورد نظر ویرایش نشد";
                return message;
            }


        }
        public Food FindMenuById(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.FoodRepository.GetById(id);
            }

        }
        public string DeleteMenuById(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var result = db.FoodRepository.Delete(id);
                string message = result ? "با موفقیت حذف شد" : "غذا مورد نظر حذف نشد";
                return message;
            }

        }
    }
}
