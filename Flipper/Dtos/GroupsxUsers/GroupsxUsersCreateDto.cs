using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Dtos
{
    public class GroupsxUsersCreateDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdGroup { get; set; }
        [Required]
        public int IdUser { get; set; }
    }
}