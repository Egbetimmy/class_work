using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using UserManagement.Data;
using UserManagement.Helper;
using UserManagement.Helpers;
using UserManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserManagement.Controllers
{
    //[ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // GET: api/<UserController>
        [HttpGet]
        [Route("get")]
        public async Task <IActionResult> Get()
        {
            var users = await  _dataContext.Users.ToListAsync();

            if (users == null || users.Count == 0)
            {
                return NotFound("No users found");
            }

            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _dataContext.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound("User not found");
            }

            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Create([FromBody] User model)
        {
            if (!PhoneNumberValidator.IsValidPhoneNumber(model.PhoneNumber))
            {
                return BadRequest("Invalid phone number format");
            }

            if (!PasswordValidator.IsStrongPassword(model.Password))
            {
                return BadRequest("Password does not meet the requirements");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_dataContext.Users.Any(u => u.Email == model.Email))
            {
                return Conflict("Email already exists");
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(model.Password);

            // Store the hashed password in the User object
            model.Password = hashedPassword;

            _dataContext.Users.Add(model);
            await _dataContext.SaveChangesAsync();

            return Ok("User created successfully");
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] User updatedUser)
        {
            var user = await _dataContext.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound("User not found");
            }

            // Update the existing user's information
            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.PhoneNumber = updatedUser.PhoneNumber;

            // Save changes to the database
            await _dataContext.SaveChangesAsync();

            return Ok("User updated successfully");
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var user = await _dataContext.Users.FindAsync(Id)
    ;

            if (user == null)
            {
                return NotFound("User not found");
            }

            _dataContext.Users.Remove(user);
            await _dataContext.SaveChangesAsync();

            return Ok("User deleted successfully");
        } 

    }

}
