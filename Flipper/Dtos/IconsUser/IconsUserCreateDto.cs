using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Dtos
{
    public class IconsUserCreateDto
    {
        [Key]
        public int IdIconUser { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
