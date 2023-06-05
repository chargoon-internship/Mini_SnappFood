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
        private static string MainValidation(Food food)
        {
      
            var NameOfFood=food.Name;
            var PriceOfFood = food.Price;
            bool chRegx= CheckRegex("Name",NameOfFood);


            if (NameOfFood == "" || PriceOfFood == 0)
                return "لطفا تمام گزینه ها را پر کنید.";
            else if (!chRegx)
                return "نام غذا ترکیبی از حروف می باشد.";
            else return "موفقیت";
        }
        public static string EditValidation(Food food)
        {
            bool uniqFood;
            string result = MainValidation(food);
            using (UnitOfWork db = new UnitOfWork())
            {
                uniqFood = db.FoodRepository.IsExistUpdate(food);
            }
            if (uniqFood)
                return "نام غذا تکراری است";
            return result;
        }
        public static string AddValidation(Food food)
        {
            bool uniqFood;
            string result= MainValidation(food);
            using (UnitOfWork db = new UnitOfWork())
            {
                uniqFood = db.FoodRepository.IsExistFood(food.Name);
            }
            if (uniqFood)
                return "نام غذا تکراری است";
            return result;
        }
        
        private static bool CheckRegex(string pattern,string target)
        {
            Regex rg = null;
            switch (pattern)
            {
                case "Name":
                    rg = new Regex(RegexConstants.PatternName);
                    break;
                case "Address":
                    rg = new Regex(RegexConstants.Address);
                    break;
                case "NationalCode":
                    rg = new Regex(RegexConstants.NationalCode);
                    break;
            }

            if (rg != null)
            {
                return rg.IsMatch(target);
            }
            else
            {
                return false;
            }
        }
    }

}
