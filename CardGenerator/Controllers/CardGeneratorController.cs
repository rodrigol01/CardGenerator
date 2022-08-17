using Microsoft.AspNetCore.Mvc;

namespace CardGenerator.Controllers;

[ApiController]
[Route("[controller]")]
public class CardGeneratorController : ControllerBase
{
    [HttpGet(Name = "GetAnything")]
    public IActionResult Get()
    {
        return Ok();
    }
}