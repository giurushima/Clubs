using Clubs.DBContexts;
using Clubs.Entities;
using Clubs.Models;

namespace Clubs.Data
{
    public class UsersRepository : IUsersRepository
    {
        internal readonly ClubsContext _context;

        public UsersRepository(ClubsContext context)
        {
            this._context = context;
        }

        public User? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            return _context.Users.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
        }

        public bool SaveChange()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
