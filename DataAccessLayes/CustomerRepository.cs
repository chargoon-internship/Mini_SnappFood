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
            DB = dB;
        }

        private DB DB;

        public IEnumerable<Customer> GetAll()
        {
            return DB.Customers;
        }

        public bool Insert(User user)
        {
            try
            {
                DB.Users.Add(user);
                Save();
                return true;
            }
            catch(Exception ex) 
            {
                throw ex;
                return false; 
            }

        }

        public void Save()
        {
            DB.SaveChanges();
        }
    }
}
