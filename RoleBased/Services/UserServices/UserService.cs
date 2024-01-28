using BITMAS.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using RoleBased.Models;

namespace RoleBased.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMemoryCache _cache;

        public UserService(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> UserExists(int userid)
        {
            return _context.Users.Any(p => p.Id == userid);
        }

        public async Task<Response<bool>> AuthenticateUser(UserLoginDTO loginDto)
        {
            try
            {
                if (string.IsNullOrEmpty(loginDto.Username) || string.IsNullOrEmpty(loginDto.Password))
                {
                    return new Response<bool>
                    {
                        Message = "Invalid username or password",
                        Code = "400", // You can customize the code
                        Data = false
                    };
                }

                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == loginDto.Username);

                if (user == null)
                {
                    return new Response<bool>
                    {
                        Message = "User not found",
                        Code = "404", // You can customize the code
                        Data = false
                    };
                }

                bool isPasswordValid = BCrypt.Net.BCrypt.Verify(loginDto.Password, user.Password);

                if (!isPasswordValid)
                {
                    return new Response<bool>
                    {
                        Message = "Invalid credentials",
                        Code = "401", // You can customize the code
                        Data = false
                    };
                }

                // var token = GenerateJwtToken.GenerateToken(loginAdminDto.Email);
                return new Response<bool>
                {
                    Message = "Authentication successful",
                    Code = "200", // You can customize the code
                    Data = true
                };
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred during user authentication: {ex.Message}");

                return new Response<bool>
                {
                    Message = "An error occurred during user authentication",
                    Code = "500", // You can customize the code
                    Data = false
                };
            }
        }

        public async Task<Response<User>> CreateUser(User userDto)
        {
            try
            {
                // Hash the password using PasswordHashService before saving
                var otp = GenerateOTP.OTP(); // Generate OTP

                var user = new User
                {
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Email = userDto.Email,
                    Password = BCrypt.Net.BCrypt.HashPassword(userDto.Password), // Hash the password
                    OTP = otp, // Assign the generated OTP
                    ResetToken = otp
                };

                _cache.Set("tempUser", user);

                // Perform your additional validation logic here
                if (user != null)
                {
                    // Return success response
                    return new Response<User>
                    {
                        Message = "User created successfully",
                        Code = "200", // You can customize the code
                        Data = user
                    };
                }

                // Return null if validation fails
                return new Response<User>
                {
                    Message = "Validation failed",
                    Code = "400", // You can customize the code
                    Data = null
                };
            }
            //catch (CustomValidationException customEx)
            //{
            //    // Handle the custom validation exception
            //    Console.WriteLine($"Custom validation error: {customEx.Message}");

            //    // Return custom error response
            //    return new Response<User>
            //    {
            //        Message = customEx.Message,
            //        Code = "400", // You can customize the code
            //        Data = null
            //    };
            //}
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred while creating the user: {ex.Message}");

                // Return generic error response
                return new Response<User>
                {
                    Message = "An error occurred while creating the user",
                    Code = "500", // You can customize the code
                    Data = null
                };
            }
        }

        public async Task<Response<bool>> DeleteUser(User modelUser)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(p => p.Id == modelUser.Id);

                if (user != null)
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync(); // Save changes to the database

                    return new Response<bool>
                    {
                        Message = "User deleted successfully",
                        Code = "200", // You can customize the code
                        Data = true
                    };
                }

                return new Response<bool>
                {
                    Message = "User not found",
                    Code = "404", // You can customize the code
                    Data = false
                };
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"An error occurred while deleting the user: {ex.Message}");

                return new Response<bool>
                {
                    Message = "An error occurred while deleting the user",
                    Code = "500", // You can customize the code
                    Data = false
                };
            }
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

        public async Task SaveResetToken(int userId, string resetToken, DateTime expirationTime)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePassword(int userId, string newPassword)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ValidateOTP(OTPDTO validateOTPDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ValidateResetToken(int userId, string resetToken)
        {
            throw new NotImplementedException();
        }
    }
}
