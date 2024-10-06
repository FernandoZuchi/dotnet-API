using Microsoft.AspNetCore.Mvc;

namespace dotnet_C__API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

    public IActionResult GetById([FromRoute] int i)
    {
        var response = new User
        {
            Id = 1,
            Age = 21,
            Name = "Fernando"
        };

        return Ok(response);
    }
}
