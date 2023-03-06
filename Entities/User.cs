using Clubs.Enums;
using System.ComponentModel.DataAnnotations;

namespace Clubs.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(32)]
        public string? Name { get; set; }
        [MaxLength(32)]
        public string? LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        public UserTypes Role { get; set; }

    }
}
