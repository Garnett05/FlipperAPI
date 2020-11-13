using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Models
{
    public class IconsUser
    {
        [Key]
        public int IdIconUser { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int IdUser { get; set; }
    }
}
