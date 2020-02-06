using System.Collections.Generic;
using ContactApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]   
    public class ContactController : ControllerBase
    {
        static List<Contact> contacts = new List<Contact>() { 
            new Contact(){Id=1, FirstName="Princy",LastName="Kalsi",contactType=ContactType.mobile,Phone="9876543210"},
            new Contact(){Id=2,FirstName="Annei",LastName="Kaur", contactType=ContactType.personal,Phone="1234567890"},
            new Contact(){Id=3,FirstName="Jamey",LastName="Wilson", contactType=ContactType.work,Phone="7890543222"},
            new Contact(){Id=4,FirstName="Fred",LastName="Belotte", contactType=ContactType.work,Phone="99999999999999" }
        };

        public IEnumerable<Contact> Get()
        {
            return contacts;
        }
        [HttpPost]
        public IActionResult Post([FromBody]Contact contact)
        {
            contacts.Add(contact);
            return Ok($"{ contact.Id} is added");
        }

    }
}