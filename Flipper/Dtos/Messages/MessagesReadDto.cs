using Flipper.Models;

namespace Flipper.Dtos
{
    public class MessagesReadDto
    {
        public int IdMsg { get; set; }
        public int IdGroup { get; set; }
        public string Msg { get; set; }
        public int IdUser { get; set; }
    }
}
