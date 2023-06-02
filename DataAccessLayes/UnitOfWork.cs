using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes
{
    public class UnitOfWork:IDisposable
    {
        private DB dB = new DB();

        private CustomerRepository? _customerRepository;

        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(dB);
                }
                return _customerRepository;
            }
        }

        public void Dispose()
        {
            dB.Dispose();
        }
    }
}
