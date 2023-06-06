using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Restaurant:IEntity
    {
        public Restaurant()
        {
            Foods= new List<Food>();

            Invoices= new List<Invoice>();
        }
        [Key,ForeignKey("User")]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; } = "";

        [Required]
        [StringLength(150)]
        public string NameOfRestaurant { get; set; } = "";

        public TimeSpan BeginDate { set; get; }

        public TimeSpan EndDate { set; get; }

        public List<Food> Foods { get; set; }

        public User? User { get; set; }

        public List<Invoice> Invoices { get; set; }

    }
}
