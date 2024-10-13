using Microsoft.AspNetCore.Mvc;

namespace dotnet_C__API;

[ApiController]
[Route("api/[controller]")]
public abstract class MyFirstApiBaseController : ControllerBase
{
    public String Author { get; set; } = "Fernando Zuchi";

    [HttpGet("heathy")]
    public IActionResult Heathy()
    {
        return Ok("It's working");
    }

    public string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
