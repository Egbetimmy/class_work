using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    public CustomersController()
    {

    }

    [HttpGet, Authorize]
    public IEnumerable<string> Get()
    {
        return new string[] { "John Doe", "Jane Doe" };
    }
}