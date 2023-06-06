using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserCud
    {
        public string Create(User user)
        {
            string validation = UserValidation.Validation(user, false);
            if (validation == "موفقیت")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (db.UserRepository.Insert(user))
                    {
                        return "ثبت نام شما با موفقیت انجام شد";
                    }
                    else
                    {
                        return "مشکلی در ثبت اطلاعات پیش آمده است";
                    }
                }
            }
            else
            {
                return validation;
            }

        }

        public bool Login(string username, string password)
        {
            using(UnitOfWork db=new UnitOfWork())
            {
                if (db.UserRepository.Login(username, password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public User GetUser(string username)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.UserRepository.GetByUserName(username);
            }
        }
    }
}
