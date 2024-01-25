using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ApiCart api; 
        public CartController(ApiCart api)
        {

            this.api = api;
        }

        [HttpGet("cart")]
        public async Task<IActionResult> getcart(int id)
        {
            return Ok(await api.CartAsync(id));
        } 

        [HttpGet("all-carts")]
        public async Task<IActionResult> getAllcart()
        {
            return Ok(await api.AllCartsAsync());
        }
    }
}
