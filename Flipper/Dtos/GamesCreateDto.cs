using System.ComponentModel.DataAnnotations;

namespace Flipper.Dtos
{
    public class GamesCreateDto
    {
        //public int Id { get; set; } O autoincrement ocorre direto no DB
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}