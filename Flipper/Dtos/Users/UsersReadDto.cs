using Flipper.Models;
using System;

namespace Flipper.Dtos
{
    public class UsersReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime birth { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Psw { get; set; }
        public string ImageUrl { get; set; }
    }
}
