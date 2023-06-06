using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Rertaurant;

namespace BusinessLogicLayer
{
    public class CustomerPanel
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public List<Restaurant> GetRestaurants()
        {
            List<Restaurant> allRestaurants = unitOfWork.RestaurantRepository.GetAll().ToList();
            return allRestaurants;
        }

        public List<string> RestaurantShowData()
        {
            List<string> result = new List<string>();
            RestaurantDto restaurantinfo = new RestaurantDto();
            var restaurants = GetRestaurants();

            foreach(var restaurant in restaurants)
            {
                restaurantinfo.RestaurantName = restaurant.NameOfRestaurant;/*
                restaurantinfo.RestaurantType = restaurant.RestaurantType;
                restaurantinfo.RestaurantScore = restaurant.RestaurantScore;*/
                restaurantinfo.Address = restaurant.Address;
                result.Add(restaurantinfo.ToString());
            }

            return result;
        }

    }
}
