using Clubs.Entities;
using Clubs.Models;

namespace Clubs.Services
{
    public interface IAuthenticationServices
    {
        User? ValidateUser(AuthenticationRequestBody authenticationRequestBody);
    }
}
