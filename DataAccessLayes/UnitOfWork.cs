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
        private FoodRepository? _foodRepository;

        public FoodRepository FoodRepository
        {
            get
            {
                if (_foodRepository == null)
                {
                    _foodRepository = new FoodRepository(dB);
                }
                return _foodRepository;
            }
        }
        private RestaurantRepository? _restaurantRepository;

        public RestaurantRepository RestaurantRepository
        {
            get
            {
                if (_restaurantRepository == null)
                {
                    _restaurantRepository = new RestaurantRepository(dB);
                }
                return _restaurantRepository;
            }
        }

        private UserRepository? _userRepository;

        public UserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(dB);
                }
                return _userRepository;
            }
        }

        public void Dispose()
        {
            dB.Dispose();
        }
    }
}
