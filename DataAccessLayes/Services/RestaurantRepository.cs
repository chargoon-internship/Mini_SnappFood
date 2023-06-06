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

        private DB db;
        public RestaurantRepository(DB db):base(db)
        {
            this.db = db;
        }
    }
}
