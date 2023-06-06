using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Food:IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; } = "";

        public bool Exist { get; set; }

        [NotMapped]
        public int Quantity { get; set; }

        public double Price { get; set; }

        [ForeignKey("Restaurant")]
        public int Restaurant_Id { get; set; }

        public Restaurant? Restaurant { get; set; }
    }
}
