using System;
using System.Collections.Generic;
using ContactApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ContactApi.Controllers
{
    [Route("api/[controller]")]   
    public class ContactController : ControllerBase
    {
        private readonly ContactStore _contactStore;
        public ContactController(ContactStore contactStore)
        {
            _contactStore = contactStore ?? throw new ArgumentNullException(nameof(ContactStore));
        }  

        [HttpGet]// author: developer name-> added the annotations
        public IEnumerable<Contact> Get()
        {
             return _contactStore.contacts;
            //return Content("string");
        }

        [HttpGet("{id}",Name ="Get")]
        public Contact Get(int id)
        {
            return _contactStore.contacts.FirstOrDefault(x=>x.Id==id);
        }
        [HttpPost]
        public IActionResult Post([FromBody, Bind("FirstName,LastName,Phone,contactType")]Contact contact)
        {
            // we don't need this, because with [ApiController] attribute,
            // we automatically do this on every action method:
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest("all error infos"); // 400, client error
            //}

            // other validation besides data annotations, you'll need to return BadRequest manually.

            // the client can't set the ID
            int newid =_contactStore.contacts.Max(x=>x.Id) + 1;
            contact.Id = newid;
            _contactStore.contacts.Add(contact);
            
            // in a response to POST, you're supposed to
            // send "201 Created" status, with a Location header indicating
            // the URL of the newly created resource, and a representation of the
            // new resource in the body.
            return CreatedAtRoute("Get", new { Id = newid }, contact);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Contact contact)
        {
            if (_contactStore.contacts.FirstOrDefault<Contact>(x=>x.Id==id) is Contact oldContact)
            {
                oldContact.FirstName = contact.FirstName;
                oldContact.LastName = contact.LastName;
                oldContact.Phone = contact.Phone;
                oldContact.contactType = contact.contactType;
                return NoContent();// 204 success and nothing is in the body
            }
            // not found (404)
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_contactStore.contacts.FirstOrDefault<Contact>(x => x.Id == id) is Contact oldContact)
            {
                _contactStore.contacts.Remove(oldContact);
                return NoContent();
            }
            // not found (404)
            return NotFound();
        }
    }
}
