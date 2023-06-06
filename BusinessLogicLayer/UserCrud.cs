using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserCrud
    {
        public bool Create(User user)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                return db.UserRepository.Insert(user);
            }
        }

        public bool Login(string username, string password)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                return db.UserRepository.Login(username, password);
            }
        }

        public User GetUser(string username)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                return db.UserRepository.GetByUserName(username);
            }
        }
    }
}
