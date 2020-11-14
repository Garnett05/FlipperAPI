using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Models
{
    public class Groups
    {
        [Key]
        public int Id { get; set; }
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
        [Required]
        public int IdIcon { get; set; }
    }
}
