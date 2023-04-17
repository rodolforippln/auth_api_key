using appKey.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace appKey.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{

    [HttpPost("")]
    [ApiKey]
    public IActionResult Get()
    {
        return Ok("Olá mundo!!");
    }
}