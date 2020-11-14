using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nickname { get; set; }
        [Required]
        [MaxLength(20)]
        public string Psw { get; set; }
        [Required]
        public int IdIcon { get; set; }

    }
}
