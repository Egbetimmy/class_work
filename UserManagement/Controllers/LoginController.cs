using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BCryptNet = BCrypt.Net.BCrypt; // Alias to avoid conflicts with the Cryptography namespace
using System.Threading.Tasks;
using UserManagement.Data;
using UserManagement.Models;
using UserManagement.Controllers;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using UserManagement.Helper;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public LoginController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //Create the custom class
        public class Response<T>
        {
            public string Message { set; get; }
            public string Code { set; get; }
            public T Data { set; get; }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var user = await _dataContext.Users.FirstOrDefaultAsync(u => u.Email == model.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.Password))
            {
                return Unauthorized("Invalid email or password");
            }

            DateTime expireAt = DateTime.Now.AddMinutes(5);

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));

            var claims = new List<Claim>
                {
                    //new Claim(ClaimType.UserName, user.UserName),
                    //new Claim(ClaimType.OTP, user.Password),
                    new Claim(ClaimTypes.Name, user.Password),
                    new Claim(ClaimTypes.UserData, user.Password)
                };

            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokeOptions = new JwtSecurityToken(
                issuer: "https://localhost:5001&quot",

                audience: "https://localhost:5001&quot",

                claims: claims,
                expires: expireAt,
                signingCredentials: signinCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

            var authToken = new AuthToken { ExpireAt = $"{expireAt}", Token = tokenString };

            var r = new Response<AuthToken> { Data = authToken, Code = "", Message = "" };

            return Ok(r);
        }
    }
}
