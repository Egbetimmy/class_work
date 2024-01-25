using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement;
using UserManagement.Models;

namespace usermanagement.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productscontroller : ControllerBase
    {
        private readonly ApiResource api;

        public productscontroller(ApiResource api)
        {
            this.api = api;
        }

        [HttpGet("product")]
        public async Task<IActionResult> GetProduct(int id)
        {
            return Ok(await api.ProductAsync(id));
        }

        [HttpGet("all-product")]
        public async Task<IActionResult> GetAllProduct()
        {
            return Ok(await api.AllProductAsync());
        }

        [HttpPost("create-product")]
        public async Task<IActionResult> CreateProduct([FromBody] Products product)
        {
            if (product == null)
            {
                return BadRequest("Invalid product data");
            }

            // You can add any additional validation logic here before sending the request.

            // Call the API resource to perform the POST request
            var response = await api.PostProductAsync(product);

            if (response.IsSuccessStatusCode)
            {
                return Ok("Product created successfully");
            }
            else
            {
                // Handle the case where the POST request was not successful
                return StatusCode((int)response.StatusCode, "Failed to create product");
            }
        }
    }
}
