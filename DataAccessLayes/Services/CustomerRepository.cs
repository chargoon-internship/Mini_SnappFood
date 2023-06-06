using DataAccessLayes.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes.Services
{
    public class CustomerRepository:GenericRepository<Customer>
    {
        public CustomerRepository(DB dB) : base(dB)
        {
            DB = dB;
        }

        private DB DB;

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
