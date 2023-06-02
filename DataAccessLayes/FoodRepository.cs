using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayes
{
    public class FoodRepository
    {
        private DB DB;

        public FoodRepository(DB dB)
        {
            this.DB = dB;
        }

        public void Insert(Food food)
        {
            DB.Foods.Add(food);
        }
    }
}
