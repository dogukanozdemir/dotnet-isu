using ISU_BT_PROJECT.Models;
using Microsoft.EntityFrameworkCore;


namespace ISU_BT_PROJECT.Data
{
    public class AuthenticateLogin : ILogin
    {
        private readonly MySQLContext _context;

        public AuthenticateLogin(MySQLContext context)
        {
            _context = context;
        }
        public async Task<BTUser> AuthenticateUser(string username, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(authUser => authUser.Username == username &&
            verifyPassword(password));
        }

        public async Task<IEnumerable<BTUser>> getuser()
        {
            return await _context.Users.ToListAsync();
        }

        private static bool verifyPassword(string rawPassword)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(rawPassword);
            return BCrypt.Net.BCrypt.Verify(rawPassword, passwordHash);
        }
    }
}
