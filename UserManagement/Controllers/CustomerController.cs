using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    [Authorize] // Apply authorization to the entire controller
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly UserManager<User> _userManager;

        public CustomerController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound(); // Return a 404 Not Found if the user is not found
            }

            return View(user); // Return the view to edit user details
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User updatedUser)
        {
            if (!ModelState.IsValid)
            {
                // If model validation fails, return the edit view with validation errors
                return View(updatedUser);
            }

            var user = await _userManager.FindByIdAsync(updatedUser.Id.ToString());

            if (user == null)
            {
                return NotFound(); // Return a 404 Not Found if the user is not found
            }

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.PhoneNumber = updatedUser.PhoneNumber;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home"); // Redirect to the home page after successful update
            }

            // If the update fails, add model errors and return the edit view
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(updatedUser);
        }
    }
}
