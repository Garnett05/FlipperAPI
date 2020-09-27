using System.ComponentModel.DataAnnotations;

namespace Flipper.Models
{
    public class Games
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
