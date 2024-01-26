using RoleBased.Models;

namespace RoleBased.Services.UserServices
{
    public interface IUserService
    {
        Task<ICollection<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<User> GetUserByEmail(string email);
        Task<User> CreateUser(User adminDto);
        Task<bool> UserExists(int adminid);
        Task<bool> DeleteUser(User AdminModel);
        Task<bool> IsEmailExists(string email);
        Task<bool> UpdateUser(User admin);
        Task<bool> AuthenticateUser(UserLoginDTO loginAdminDto);
        Task<bool> ValidateOTP(OTPDTO validateOTPDto);
        Task<bool> Save();

        // Additional methods for password reset
        Task SaveResetToken(int adminId, string resetToken, DateTime expirationTime);
        Task<bool> ValidateResetToken(int adminId, string resetToken);
        Task UpdatePassword(int adminId, string newPassword);
    }
}
