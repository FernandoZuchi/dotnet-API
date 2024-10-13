using Microsoft.AspNetCore.Mvc;

namespace dotnet_C__API;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    protected IActionResult Get()
    {
        var key = GetCustomKey();

        return Ok(key);
    }
}
