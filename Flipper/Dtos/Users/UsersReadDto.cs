using Flipper.Models;

namespace Flipper.Dtos
{
    public class UsersReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Psw { get; set; }
        public int ImageUrl { get; set; }
    }
}
