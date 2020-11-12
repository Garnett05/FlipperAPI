using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Dtos
{
    public class MessagesCreateDto
    {   [Key]    
        public int IdMsg { get; set; }
        [Required]
        public int IdGroup { get; set; }
        [Required]
        public string Msg { get; set; }
        [Required]
        public int IdUser { get; set; }
    }
}
