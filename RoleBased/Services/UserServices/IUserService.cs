using RoleBased.Models;

namespace RoleBased.Services.UserServices
{
    public interface IUserService
    {
        ICollection<User> GetAdmins();
        User GetUser(int id);
        User GetUserByEmail(string email);
        User CreateAdmin(User adminDto);
        bool UserExists(int adminid);
        bool DeleteAdmin(User AdminModel);
        bool IsEmailExists(string email);
        bool UpdateAdmin(User admin);
        bool AuthenticateAdmin(UserLoginDTO loginAdminDto);
        bool ValidateOTP(OTPDTO validateOTPDto);
        bool Save();

        // Additional methods for password reset
        void SaveResetToken(int adminId, string resetToken, DateTime expirationTime);
        bool ValidateResetToken(int adminId, string resetToken);
        void UpdatePassword(int adminId, string newPassword);
    }
}
