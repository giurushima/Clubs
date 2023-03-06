using Clubs.Entities;
using Clubs.Enums;
using Microsoft.EntityFrameworkCore;

namespace Clubs.DBContexts
{
    public class ClubsContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<User> Users { get; set; }

        public ClubsContext(DbContextOptions<ClubsContext> options) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
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
                    ClubId = clubs[0].Id
                },
                new Player("Cristiano Ronaldo")
                {
                    Id = 2,
                    Nationality = "Portugal",
                    Position = Position.Attacker,
                    ClubId = clubs[1].Id

                },
                new Player("Luka Modric")
                {
                    Id = 3,
                    Nationality = "Croacia",
                    Position = Position.Midfielder,
                    ClubId = clubs[2].Id
                });

            var users = new User[3] {
                new User()
                {
                    Id = 1,
                    Name = "Felipe",
                    LastName = "Regis",
                    Password = "feli99",
                    UserName = "feliregis",
                    Role = UserTypes.administrator

                },
                 new User()
                {
                    Id = 2,
                    Name = "Mateo",
                    LastName = "Garcia",
                    Password = "mateo99",
                    UserName = "mategarcia",
                    Role = UserTypes.administrator

                },
                  new User()
                {
                    Id = 3,
                    Name = "Gabriel",
                    LastName = "Urushima",
                    Password = "gabi99",
                    UserName = "gabiurushima",
                    Role = UserTypes.administrator

                }

            };

            modelBuilder.Entity<User>().HasData(users);

            base.OnModelCreating(modelBuilder);
        }
    }
}
