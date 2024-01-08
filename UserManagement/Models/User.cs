using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models
{
    public class User

    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

    }
}
