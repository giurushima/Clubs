using Clubs.Enums;

namespace Clubs.Models
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string? Nationality { get; set; } 
        public Position Position { get; set; }
    }
}
