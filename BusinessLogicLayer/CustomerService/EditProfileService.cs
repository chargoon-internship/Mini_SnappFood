using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayes;
using Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace BusinessLogicLayer.CustomerService
{

    public class EditProfileService
    {
        public User FindUserById(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.UserRepository.GetById(id);
            }
        }
        public Customer FindCustomer(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.CustomerRepository.GetById(id);
            }
        }
        public Restaurant FindRestaurant(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.RestaurantRepository.GetById(id);
            }
        }

        public List<string> UpdateProfile(User user)
        {
            var results = new List<string>();
            bool isEdit = true;
            string validation = UserValidation2.Validation(user, isEdit);

            results.Add(validation);
            if (validation == "موفقیت")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var result = db.UserRepository.Update(user);
                    string message = result ? "با موفقیت ویرایش شد" : "عدم موفقیت در ویرایش";
                    results.Add(message);
                    return results;
                }
            }
            results.Add("نا موفق");
            return results;
        }
        public string DeleteUser(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var result = db.UserRepository.Delete(id);
                string message = result ? "حساب کاربری با موفقیت حذف شد" : "حساب کاربری حذف نشد";
                return message;
            }

        }
    }
}