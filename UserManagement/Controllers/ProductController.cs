//Controller

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
        public async Task<IActionResult> getproduct(int id)
        {
            return Ok(await api.ProductAsync(id));
        }

        [HttpGet("all-product")]
        public async Task<IActionResult> getAllproduct()
        {
            return Ok(await api.AllProductAsync());
        }
    }
}