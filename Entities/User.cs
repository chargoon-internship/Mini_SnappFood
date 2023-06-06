using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User:IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = "";

        [Required]
        [StringLength(50)]
        public string UserName { get; set; } = "";

        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";


        public Customer? Customer { get; set; }

        public Restaurant? Restaurant { get; set; }



    }
}
