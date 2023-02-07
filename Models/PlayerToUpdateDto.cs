using Clubs.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clubs.Models
{
    public class PlayerToUpdateDto
    {
        [Required(ErrorMessage = "Agrega un nombre completo")]
        [MaxLength(50)]
        public string FullName { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Nationality { get; set; }
        [MaxLength(50)]
        public Position Position { get; set; }
    }
}
