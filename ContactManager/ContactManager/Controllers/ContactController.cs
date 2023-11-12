using Microsoft.AspNetCore.Mvc;
using ContactManager.Models; 

[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    [HttpGet]
    public Contact[] Get()
    {
        return new Contact[]
        {
        new Contact
        {
            Id = 1,
            Name = "Glenn Block"
        },
        new Contact
        {
            Id = 2,
            Name = "Dan Roth"
        }
        };
    }
}

