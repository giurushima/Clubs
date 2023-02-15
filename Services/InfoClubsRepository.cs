using Clubs.DBContexts;
using Clubs.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clubs.Services
{
    public class InfoClubsRepository : IInfoClubsRepository
    {
        private readonly ClubsContext _context;

        public InfoClubsRepository(ClubsContext context)
        {
            _context = context;
        }
        public Club? GetClub(int idClub)
        {
            return _context.Clubs.Include(c => c.Players).Where(d => d.Id == idClub).FirstOrDefault();
        }

        public IEnumerable<Club> GetClubs()
        {
            return _context.Clubs.OrderBy(x => x.Name).ToList();
        }

        public Player? GetPlayer(int idClub, int idPlayer)
        {
            return _context.Players.Where(p => p.ClubId == idClub && p.Id == idPlayer).FirstOrDefault();
        }

        public IEnumerable<Player> GetPlayers(int idClub)
        {
            return _context.Players.Where(p => p.ClubId == idClub).ToList();
        }

        public bool ExisteClub(int idClub)
        {
            return _context.Clubs.Any(c => c.Id == idClub);
        }

        public void AgregarPlayerAClub(int idClub, Player Player)
        {
            var Club = GetClub(idClub);
            if (Club != null)
                Club.Players.Add(Player);
        }

        public bool GuardarCambios()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void EliminarPlayer(Player Player)
        {
            _context.Players.Remove(Player);
        }

        public void AgregarClub(Club club)
        {
            _context.Clubs.Add(club);
        }

        public void EliminarClub(Club club)
        {
            _context.Clubs.Remove(club);
        }

        public bool NameClubConcuerdaConIdClub(string? NameClub, int idClub)
        {
            return _context.Clubs.Any(c => c.Id == idClub && c.Name == NameClub);
        }
    }
}