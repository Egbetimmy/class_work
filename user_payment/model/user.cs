using System.Collections.Generic; // Ensure to import List<T>

namespace user_payment.model
{
    public class user // Changed class name to start with an uppercase letter
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Transaction> Payments { get; set; }
    }
}
