using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Models
{
    public class IconsGroup
    {
        [Key]
        public int IdIconGroup { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int IdGame { get; set; }
    }
}
