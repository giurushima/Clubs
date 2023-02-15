using Clubs.Entities;

namespace Clubs.Services
{
    public interface IInfoClubsRepository
    {
        public IEnumerable<Club> GetClubs();
        public Club? GetClub(int idClub);
        public IEnumerable<Player> GetPlayers(int idClub);
        public Player? GetPlayer(int idClub, int idPlayer);
        public bool ExisteClub(int idClub);
        public void AgregarPlayerAClub(int idClub, Player Player);
        void EliminarPlayer(Player Player);
        public bool GuardarCambios();
        void AgregarClub(Club club);
        void EliminarClub(Club club);
        bool NameClubConcuerdaConIdClub(string? NameClub, int idClub);
    }
}