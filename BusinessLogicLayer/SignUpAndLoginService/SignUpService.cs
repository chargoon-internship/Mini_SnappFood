using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.SignUpAndLoginService
{
    public class SignUpService
    {
        public string SignUp(User user)
        {
            if (Create(user))
            {
                return ("ثبت نام شما با موفقیت انجام شد");
            }
            else
            {
                return ("مشکلی پیش آمده است");
            }
        }

        public bool Create(User user)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.UserRepository.Insert(user);
            }
        }
    }
}
