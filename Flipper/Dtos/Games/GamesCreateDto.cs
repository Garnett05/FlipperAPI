using System.ComponentModel.DataAnnotations;

namespace Flipper.Dtos
{
    public class GamesCreateDto
    {
        //public int Id { get; set; } O autoincrement ocorre direto no DB
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}