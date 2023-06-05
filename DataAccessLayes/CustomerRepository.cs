using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes
{
    public class CustomerRepository
    {
        public CustomerRepository(DB dB)
        {
            DB= dB;
        }

        private DB DB;

        public IEnumerable<Customer> GetAll()
        {
            return DB.Customers;
        }

        public Customer GetById(int id)
        {
            return DB.Customers.Find(id);
        }
        public bool IsExistUpdate(User user)
        {
            return DB.Users.Any(u => u.Id != user.Id && u.UserName == user.UserName);
        }
        public bool IsExistUser(User user)
        {
            return DB.Users.Any(u => u.UserName == user.UserName);
        }

    }
    }
