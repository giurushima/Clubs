using Clubs.Entities;
using Clubs.Models;
using static Clubs.Controllers.AuthenticationController;

namespace Clubs.Data
{
    public interface IUsersRepository
    {
        public User? ValidateUser(AuthenticationRequestBody authRequestBody);
        public bool SaveChange();
    }
    
}
