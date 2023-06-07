using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Entities;
using Microsoft.EntityFrameworkCore;
using DataAccessLayes.Repositories;

namespace DataAccessLayes.Services
{
    public class RestaurantRepository:GenericRepository<Restaurant>
    {

        private DB _db;
        public RestaurantRepository(DB db):base(db)
        {
            _db = db;
        }
        public List<Restaurant> GetByName(string restaurantName)
        {
            return _db.Restaurants.Where(p => p.NameOfRestaurant == restaurantName).ToList();
        }
    }
}
