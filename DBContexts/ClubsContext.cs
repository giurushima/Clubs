using Clubs.Entities;
using Clubs.Enums;
using Microsoft.EntityFrameworkCore;

namespace Clubs.DBContexts
{
    public class ClubsContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }

        public ClubsContext(DbContextOptions<ClubsContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Ciudad>().HasMany(c => c.PuntosDeInteres).WithOne(p => p.Ciudad).HasForeignKey(c => c.TruckerId);

            var clubs = new Club[3]
            {
                new Club("PSG")
                {
                    Id = 1,
                    League = League.Ligue1,
                },
                new Club("Atletico Madrid")
                {
                    Id = 2,
                    League = League.LaLiga,

                },
                new Club("Real Madrid")
                {
                    Id = 3,
                    League = League.LaLiga,
                }
            };
            modelBuilder.Entity<Club>().HasData(clubs);

            modelBuilder.Entity<Player>().HasData(
                new Player("Lionel Messi")
                {
                    Id = 1,
                    Nationality = "Argentina",
                    Position = Position.Attacker,

                },
                new Player("Cristiano Ronaldo")
                {
                    Id = 2,
                    Nationality = "Portugal",
                    Position = Position.Attacker,

                },
                new Player("Luka Modric")
                {
                    Id = 3,
                    Nationality = "Croacia",
                    Position = Position.Midfielder,
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
