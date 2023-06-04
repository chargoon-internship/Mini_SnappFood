using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes
{
    public class UserRepository
    {
        private DB db;

        public UserRepository(DB db)
        {
            this.db = db;
        }

        public bool Insert(User user)
        {
            try
            {
                db.Users.Add(user);
                Save();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Update(User user)
        {
            try
            {
                db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(User user)
        {
            try
            {
                db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public User GetById(int id)
        {
            return db.Users.Find(id)!;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public bool Login(string username, string password)
        {
            var result = db.Users.SingleOrDefault(n => n.UserName == username);
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
            return db.Users.Include(n=>n.Customer).Include(n=>n.Restaurant).Single(n=>n.UserName== userName);
        }

        public bool Delete(int id)
        {
            try
            {
                var res=GetById(id);
                Delete(res);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
