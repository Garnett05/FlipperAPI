using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Dtos
{
    public class GroupsUpdateDto
    {
        //public int Id { get; set; } O autoincrement do DB contrala o Id        
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        [Required]
        public int NumberPlayers { get; set; }
        [Required]
        public int IdGame { get; set; }
        [Required]
        public int IdUserGroupLeader { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
