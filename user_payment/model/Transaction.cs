using System;

namespace user_payment.model
{
    public class Transaction // Renamed class to match the file name and corrected the property names
    {
        // Properties
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public user User { get; set; }
    }
}
