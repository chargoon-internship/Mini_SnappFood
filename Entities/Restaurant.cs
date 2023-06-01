﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Restaurant
    {
        public Restaurant()
        {
            Foods= new List<Food>();

            Invoices= new List<Invoice>();
        }
        [Key,ForeignKey("User")]
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime BeginDate { set; get; }

        public DateTime EndDate { set; get; }

        public List<Food> Foods { get; set; }

        public User User { get; set; }

        public List<Invoice> Invoices { get; set; }

    }
}
