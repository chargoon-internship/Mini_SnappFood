using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayes
{ 
    public class RestaurantRepository
    {

        private DB _db;

        public RestaurantRepository(DB db)
        {
            _db=db;
        }
        public bool Insert(Restaurant restaurant)
        {
            try
            {
                _db.Restaurants.Add(restaurant); return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Restaurant> GetAll()
        {
            return _db.Restaurants.ToList();
        }
        public Restaurant GetById(int restaurantID)
        {
            return _db.Restaurants.Find(restaurantID);
        }
        public bool Delete(int restaurantID)
        {
            try
            {
                var restaurant = GetById(restaurantID);
                Delete(restaurant);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(Restaurant restaurant)
        {
            try
            {
                _db.Restaurants.Remove(restaurant);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Restaurant restaurant)
        {
            var local = _db.Restaurants.FirstOrDefault(f => f.Id==restaurant.Id);
            if (local != null)
            {
                //_db.Entry(restaurant).State =EntityState.Modified;
                _db.SaveChanges();

                return true;
            }
            return false;
        }
    }
}
