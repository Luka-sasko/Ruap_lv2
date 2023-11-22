using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using ContactManager.Services;

[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    
    private ContactRepository contactRepository;

    public ContactController()
    {
        this.contactRepository = new ContactRepository();
    }
    [HttpGet]
    public Contact[] Get()
    {
        return this.contactRepository.GetAllContacts();
    }

    public HttpResponseMessage Post(Contact contact)
    {
        this.contactRepository.SaveContact(contact);

        var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

        return response;
    }
}

