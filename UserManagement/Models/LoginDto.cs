using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models
{
    public class LoginDto
    {
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
