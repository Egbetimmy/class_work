namespace BITMAS.Helper
{
    public class GenerateOTP
    {
        public static string OTP()
        {
            // Generate a random 6-digit OTP (you can adjust the length as needed)
            Random rand = new Random();
            int otpValue = rand.Next(100000, 999999); // 6-digit OTP
            string otp = otpValue.ToString();

            return otp;
        }
    }
}
