using Clubs.Enums;

namespace Clubs.Models
{
    public class PlayerWithOutClubsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public League League { get; set; }
    }
}
