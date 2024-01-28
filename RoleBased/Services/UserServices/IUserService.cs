using RoleBased.Models;
using static RoleBased.Services.UserServices.UserService;

namespace RoleBased.Services.UserServices
{
    public interface IUserService
    {
        Task<ICollection<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<User> GetUserByEmail(string email);
        Task<Response<User>> CreateUser(User userDto);
        Task<bool> UserExists(int userId);
        Task<Response<bool>> DeleteUser(User modelUser);
        Task<bool> IsEmailExists(string email);
        Task<bool> UpdateUser(User user);
        Task<Response<bool>> AuthenticateUser(UserLoginDTO loginDto);
        Task<bool> ValidateOTP(OTPDTO validateOTPDto);
        Task<bool> Save();

        // Additional methods for password reset
        Task SaveResetToken(int userId, string resetToken, DateTime expirationTime);
        Task<bool> ValidateResetToken(int userId, string resetToken);
        Task UpdatePassword(int adminId, string newPassword);
    }
}
