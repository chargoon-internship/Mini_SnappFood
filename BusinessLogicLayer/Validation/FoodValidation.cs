using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Text.RegularExpressions;
using BusinessLogicLayer.Enum;
using DataAccessLayes;

namespace BusinessLogicLayer
{
    public static class FoodValidation
    {
        public static string Validation(Food food, bool isEdit)
        {
      
            var NameOfFood=food.Name;
            var PriceOfFood = food.Price;
            bool chRegx= RegexValidation.CheckRegex("Name",NameOfFood);
            bool uniqFood;
            if (isEdit)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    uniqFood = db.FoodRepository.IsExistUpdate(food);
                }
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    uniqFood = db.FoodRepository.IsExistFood(food.Name);
                }
            }

            if (NameOfFood == "" || PriceOfFood == 0)
                return "لطفا تمام گزینه ها را پر کنید.";
            else if (!chRegx)
                return "نام غذا ترکیبی از حروف می باشد.";
            else if (uniqFood)
                return "نام غذا تکراری است";

            else return "موفقیت";
        }
    }

}
