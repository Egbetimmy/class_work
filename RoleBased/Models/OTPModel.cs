namespace RoleBased.Models
{
    public class OTPModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string OTP { get; set; }
        public DateTimeOffset ExpirationTime { get; set; }
    }

    public class OTPDTO
    {
        // Assuming this DTO is used for transferring OTP information
        public string OTP { get; set; }
    }
}
