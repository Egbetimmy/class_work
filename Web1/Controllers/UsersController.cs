using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController() 
        {
        }
        //[HttpPost("create")]
        //public IActionResult CreateUser([FromBody] userrequest model) 
        //{ 
        //    var user = new User 
        //    { 
        //        Email = model.Email,
        //        FirstName = model.FirstName,
        //        LastName = model.LastName,
        //    };
        //    return Ok(model);
        //}

        [HttpPost("create")]
        public IActionResult CreateProfile([FromBody] ProfileRequest model)
        {
            if (model.UserID != null && model.UserID != 0) 
            {
                var profile = new Profile
                {
                    Address = model.Address,
                    Phone = model.Phone,
                    Photo = model.Photo,
                };
                return Ok(model);
            }

            return Ok(" User does not exist");
        }
    }
}
