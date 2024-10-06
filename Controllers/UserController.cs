using Microsoft.AspNetCore.Mvc;

namespace dotnet_C__API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var response = new Response
        {
            Name = "Fernando",
            Age = 0,
        };

        return Ok(response);
    }
}
