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
        public async Task<bool> UserExists(int userid)
        {
            return _context.Users.Any(p => p.Id == userid);
        }

        public async Task<bool> AuthenticateUser(UserLoginDTO loginAdminDto)
        {
            throw new NotImplementedException();
        }

        public async Task<User> CreateUser(User userDto)
        {
            _context.Users.Add(userDto);
            await _context.SaveChangesAsync();
            return userDto;
        }

        public async Task<bool> DeleteUser(User AdminModel)
        {
            var user = _context.Users.Where(p => p.Id == AdminModel.Id).FirstOrDefault();
            if (user != null)
            {
                _context.Users.Remove(user);
                return true;
            }
            return false;
        }

        public async Task<ICollection<User>> GetUsers()
        {
            return _context.Users.ToList();
        }

        public async Task<User> GetUser(int id)
        {
            return _context.Users.Where(p => p.Id == id).FirstOrDefault();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return _context.Users.Where(p => p.Email == email).FirstOrDefault();
        }

        public async Task<bool> IsEmailExists(string email)
        {
            return _context.Users.Any(p => p.Email == email);
        }

        public async Task<bool> Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public async Task SaveResetToken(int adminId, string resetToken, DateTime expirationTime)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateUser(User admin)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePassword(int adminId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ValidateOTP(OTPDTO validateOTPDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ValidateResetToken(int adminId, string resetToken)
        {
            throw new NotImplementedException();
        }
    }
}
