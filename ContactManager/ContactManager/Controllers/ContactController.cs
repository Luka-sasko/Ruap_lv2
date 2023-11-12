using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    [HttpGet]
    public string[] Get()
    {
        return new string[]
        {
            "Hello",
            "World"
        };
    }
}
