using DataAccessLayes.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes.Services
{
    public class UserRepository:GenericRepository<User>
    {
        private DB db;

        public UserRepository(DB db):base(db)
        {
            this.db = db;
        }

        public bool Login(string username, string password)
        {
            var result = db.Users.SingleOrDefault(n => n.UserName == username);
            if (result == null)
            {
                return true;
            }
            if (result!.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetByUserName(string userName)
        {
            return db.Users.Include(n => n.Customer).Include(n => n.Restaurant).Single(n => n.UserName == userName);
        }
    }
}
