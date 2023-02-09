using Clubs.Entities;

namespace Clubs.Services
{
    public interface IInfoClubsRepository
    {
        public IEnumerable<Club> GetClubes();
        public Club? GetClub(int idClub, bool incluirPuntosDeInteres);
        public IEnumerable<Player> GetPuntosDeInteresDeClub(int idClub);
        public Player? GetPlayerDeClub(int idClub, int idPlayer);
        public bool ExisteClub(int idClub);
        public void AgregarPlayerAClub(int idClub, Player Player);
        void EliminarPlayer(Player Player);
        public bool GuardarCambios();
        bool NameClubConcuerdaConIdClub(string? NameClub, int idClub);
    }
}