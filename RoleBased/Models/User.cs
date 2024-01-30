using System.Data;

namespace RoleBased.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Role> Roles { get; set; } // Navigation property for roles
        public string ResetToken { get; internal set; }
        public string OTP { get; internal set; }
    }

    public class UserLoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
