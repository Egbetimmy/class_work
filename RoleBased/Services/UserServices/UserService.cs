using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using RoleBased.Models;

namespace RoleBased.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }
        public bool UserExists(int userid)
        {
            return _context.Users.Any(p => p.Id == userid);
        }

        public bool AuthenticateAdmin(UserLoginDTO loginAdminDto)
        {
            throw new NotImplementedException();
        }

        public User CreateAdmin(User adminDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAdmin(User AdminModel)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetAdmins()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return _context.Users.Where(p => p.Id == id).FirstOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.Where(p => p.Email == email).FirstOrDefault();
        }

        public bool IsEmailExists(string email)
        {
            return _context.Users.Any(p => p.Email == email);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public void SaveResetToken(int adminId, string resetToken, DateTime expirationTime)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAdmin(User admin)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassword(int adminId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public bool ValidateOTP(OTPDTO validateOTPDto)
        {
            throw new NotImplementedException();
        }

        public bool ValidateResetToken(int adminId, string resetToken)
        {
            throw new NotImplementedException();
        }
    }
}
