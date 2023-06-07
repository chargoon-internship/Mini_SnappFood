using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.SignUpAndLoginService
{
    public class LoginService
    {
        public (string, bool,bool) Execute(string username, string password)
        {
            bool isCustomer = false;
            if (username != "" && password != "")
            {
                if (Login(username, password))
                {

                    User myUser = GetUser(username);
                    if (myUser.Customer != null)
                    {
                        isCustomer = true;
                    }
                    else if (myUser.Restaurant != null)
                    {
                        isCustomer = false;
                    }
                    return ("شما با موفقیت وارد شددید", isCustomer,true);
                }
                else
                {
                    return ("نام کاربری و رمز عبور وارد شده، اشتباه است", isCustomer,false);
                }
            }
            else
            {
                return ("لطفا فیلد های خالی را پر نمائید", isCustomer,false);
            }
        }
        public bool Login(string username, string password)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.UserRepository.Login(username, password);
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
