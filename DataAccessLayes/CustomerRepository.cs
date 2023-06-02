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
    }
}
