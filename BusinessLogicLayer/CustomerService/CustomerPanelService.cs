using DataAccessLayes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Rertaurant;

namespace BusinessLogicLayer.CustomerService
{
    public class CustomerPanelService
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public List<Restaurant> GetRestaurants(string restaurantName)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            if(restaurantName == "")
            {
                restaurants = unitOfWork.RestaurantRepository.GetAll().ToList();
            }
            else
            {
                restaurants = unitOfWork.RestaurantRepository.GetByName(restaurantName);
            }
            return restaurants;
        }

        public List<string> ShowRestaurantsData(string restaurantName)
        {
            List<string> result = new List<string>();
            RestaurantViewModel restaurantinfo = new RestaurantViewModel();
            var restaurants = GetRestaurants(restaurantName);

            foreach (var restaurant in restaurants)
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
