﻿using Clubs.Entities;

namespace Clubs.Services
{
    public interface IInfoClubsRepository
    {
        public IEnumerable<Club> GetClubs();
        public Club? GetClub(int idClub, bool incluirPlayers);
        public IEnumerable<Player> GetPlayersDeClub(int idClub);
        public Player? GetPlayerDeClub(int idClub, int idPlayer);
        public bool ExisteClub(int idClub);
        public void AgregarPlayerAClub(int idClub, Player Player);
        void EliminarPlayer(Player Player);
        public bool GuardarCambios();
        bool NameClubConcuerdaConIdClub(string? NameClub, int idClub);
    }
}