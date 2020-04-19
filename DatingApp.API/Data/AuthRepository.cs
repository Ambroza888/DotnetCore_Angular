using System;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public Task<User> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Register(User user, string password)
        {
            // Create 2 variables with passwordHASH and passwordSALT
            // then we send those variables in the method CREATEPASSWORDHASH
            // We use "out" keyword so we can send them as empty and they have been refrenced
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
        }
        //Created CreatePasswordHash method from the register(keeping the rull of tumb to seperate functions);
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            throw new NotImplementedException();
        }

    public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}