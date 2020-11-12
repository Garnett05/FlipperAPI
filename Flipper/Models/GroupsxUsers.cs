using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Models
{
    public class GroupsxUsers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdGroup { get; set; }
        [Required]
        public int IdUser { get; set; }
    }
}
