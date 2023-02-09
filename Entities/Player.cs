using Clubs.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Clubs.Entities
{
    public class Player
    {
        [Key]//test
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        public Player(string fullName)
        {
            FullName = fullName;
        }

        [MaxLength(50)]
        public string? Nationality { get; set; }

        [Required]
        [MaxLength(50)]
        public Position Position { get; set; }

        [ForeignKey("ClubId")]
        public Club Club { get; set; }
        public int ClubId { get; set; }


    }
}
