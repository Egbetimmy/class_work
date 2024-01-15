using System;
using System.IdentityModel.Tokens.Jwt;

class Program
{
    static void Main()
    {
        // Replace "your_jwt_here" with your actual JWT
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImZhaXNhbG96aWdpc0BnbWFpbC5jb20iLCJuYW1laWQiOiIzNiIsIk9UUCI6IjMyNDQ1NCIsIm5iZiI6MTcwNTMwNjkyNywiZXhwIjoxNzA1MzEwNTI3LCJpYXQiOjE3MDUzMDY5Mjd9.f3YQ1zgaq6o0lgzZbG8V04djzi0fgh4iKCZa4hbAir0";

        try
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwt) as JwtSecurityToken;

            if (jsonToken != null)
            {
                // Extract and store payload claims
                string uniqueName = jsonToken.Claims.FirstOrDefault(c => c.Type == "unique_name")?.Value;
                string nameId = jsonToken.Claims.FirstOrDefault(c => c.Type == "nameid")?.Value;
                string otp = jsonToken.Claims.FirstOrDefault(c => c.Type == "OTP")?.Value;
                string nbf = jsonToken.Claims.FirstOrDefault(c => c.Type == "nbf")?.Value;
                string exp = jsonToken.Claims.FirstOrDefault(c => c.Type == "exp")?.Value;
                string iat = jsonToken.Claims.FirstOrDefault(c => c.Type == "iat")?.Value;

                // Use the variables as needed
                Console.WriteLine($"Unique Name: {uniqueName}");
                Console.WriteLine($"Name ID: {nameId}");
                Console.WriteLine($"OTP: {otp}");
                Console.WriteLine($"Not Before: {nbf}");
                Console.WriteLine($"Expiration Time: {exp}");
                Console.WriteLine($"Issued At: {iat}");
            }
            else
            {
                Console.WriteLine("Invalid JWT format");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}
