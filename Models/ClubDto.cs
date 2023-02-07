using Clubs.Enums;

namespace Clubs.Models
{
    public class ClubDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public League League { get; set; }
        public IList<PlayerDto> Players { get; set; } = new List<PlayerDto>();
        public int NumberOfPlayers
        { 
        get { return Players.Count; }
        }
    }
}
