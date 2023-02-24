using Clubs.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clubs.Models
{
    public class PlayerToCreateDto
    {
        [Required(ErrorMessage = "Agrega un nombre completo")]
        [MaxLength(50)]
        public string FullName { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Nationality { get; set; }
        public Position Position { get; set; }
    }
}
