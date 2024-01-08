using System.Text.RegularExpressions;

namespace UserManagement.Controllers
{
    public static class PasswordValidator
    {
        public static bool IsStrongPassword(string password)
        {
            // Regular expression for a strong password (at least 8 characters including uppercase, lowercase, number, and special character)
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            return regex.IsMatch(password);
        }
    }
}
