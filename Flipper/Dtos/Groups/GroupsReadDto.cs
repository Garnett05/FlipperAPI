using Flipper.Models;

namespace Flipper.Dtos
{
    public class GroupsReadDto
    {        
        public int Id { get; set; }        
        public string Name { get; set; }        
        public int NumberPlayers { get; set; }        
        public int IdGame { get; set; }        
        public int IdUserGroupLeader { get; set; }        
        public string ImageUrl { get; set; }
        public int IdIcon { get; set; }
    }
}
