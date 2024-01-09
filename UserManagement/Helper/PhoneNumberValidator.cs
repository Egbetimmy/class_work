using System.Text.RegularExpressions;

namespace UserManagement.Helpers
{
    public static class PhoneNumberValidator
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression to match a simple phone number format (e.g., XXX-XXX-XXXX)
            var regex = new Regex(@"^\d{3}-\d{3}-\d{4}$");

            return regex.IsMatch(phoneNumber);
        }
    }
}
