using System.ComponentModel.DataAnnotations;

namespace Clubs.Models
{
    public class AuthenticationRequestBody
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
