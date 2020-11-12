using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Models
{
    public class Messages
    {
        [Key]
        public int IdMsg { get; set; }
        [Required]
        public int IdGroup { get; set; }
        [Required]
        public string Msg { get; set; }
        [Required]
        public int IdUser { get; set; }
    }
}
