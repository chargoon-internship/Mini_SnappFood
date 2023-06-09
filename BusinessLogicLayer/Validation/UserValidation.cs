using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Enum;
using DataAccessLayes;
using Entities;
namespace BusinessLogicLayer
{
    public static class UserValidation
    {
        public static string Validation(User user, bool isEdit)
        {

            bool chFirstName = RegexValidation.CheckRegex("Name", user.FirstName);
            bool chLastName = RegexValidation.CheckRegex("Name", user.LastName);
            bool chUsername = RegexValidation.CheckRegex("UserName", user.UserName);
            bool chPassword = RegexValidation.CheckRegex("PassWord", user.Password);
            bool uniqUsername;
            if (isEdit)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    uniqUsername = db.CustomerRepository.IsExistUpdate(user);
                }
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    uniqUsername = db.CustomerRepository.IsExistUser(user);

                }
            }

            if (user.Customer != null)
            {

                bool chNationalCode = RegexValidation.CheckRegex("NationalCode", user.Customer.NatioalCode);
                bool chAddress = RegexValidation.CheckRegex("Address", user.Customer.HomeAddress);
                if (!chNationalCode)
                    return "کدملی معتبر نمی باشد";
                else if (!chAddress)
                    return "آدرس معتبر نمی باشد";
            }
            else
            {
                bool chNameRestaurant = RegexValidation.CheckRegex("UserName", user.Restaurant.NameOfRestaurant);
                bool chAddress = RegexValidation.CheckRegex("Address", user.Restaurant.Address);
                if (!chNameRestaurant)
                    return "نام رستوران معتبر نمی باشد";
                else if (!chAddress)
                    return "آدرس معتبر نمی باشد";
/*                else if (user.Restaurant.BeginDate.ToString()== "00:00:00" || user.Restaurant.EndDate.ToString()== "00:00:00")
                    return "ساعت کاری رستوران را به درستی وارد کنید";*/

            }
            /*
                        if (user.UserName == "" || user.Password == "")
                            return "لطفا نام کاربری و رمز را وارد کنید.";
                        else if (user.Customer != null && user.Customer.HomeAddress == "")
                        {
                            return "لطفا آدرس را وارد کنید";
                        }
                        else if (user.Customer == null && (user.Restaurant.NameOfRestaurant == "" || user.Restaurant.Address == ""))
                        {
                            return "لطفا نام رستوران و آدرس را وارد کنید";
                        }
                        else if (user.Customer == null && (user.Restaurant.NameOfRestaurant == "" || user.Restaurant.Address == ""))
                        {
                            return "لطفا نام رستوران و آدرس را وارد کنید";
                        }*/
            if (!chFirstName)
                return "نام  ترکیبی از حروف می باشد.";
            else if (!chLastName)
                return "نام  خانوادگی ترکیبی از حروف می باشد.";
            else if (!chUsername)
                return "نام کاربری بین 3 تا 16 کاراکتر که ترکیبی از حروف اعداد و خطوط تیره می باشد";
            else if (!chPassword)
                return "حداقل طول رمز 8 می باشد و باید حتما ترکیبی از حروف بزرگ و کوچک و اعداد باشد";
            else if (uniqUsername)
                return "نام کاربری تکراری است";
            else return "موفقیت";

        }


    }
}
