using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayes;
using Entities;
using ViewModel;
using ViewModel.Food;

namespace BusinessLogicLayer.RestaurantService
{
    public class EditMenuService
    {
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
        public string AddMenu(Food food, bool isEdit, int Id)
        {
            string validation = FoodValidation.Validation(food, isEdit, Id);

            if (validation == "موفقیت")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    db.FoodRepository.Insert(food);
                }
            }
            return validation;


        }
        public List<string> UpdateMenu(Food food, int Id)
        {
            var results = new List<string>();
            bool isEdit = true;
            string validation = FoodValidation.Validation(food, isEdit, Id);
            results.Add(validation);
            if (validation == "موفقیت")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var result = db.FoodRepository.Update(food);
                    string message = result ? "با موفقیت ویرایش شد" : "غذا مورد نظر ویرایش نشد";
                    results.Add(message);
                    return results;
                }
            }
            results.Add("نا موفق");
            return results;


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
