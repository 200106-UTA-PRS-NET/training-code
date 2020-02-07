using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactWeb.Data;
using ContactWeb.Models;
using System.Net.Http;

namespace ContactWeb.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public IActionResult Index()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44342/api/contact";
                client.BaseAddress = new Uri(url);
                var response = client.GetAsync("contact");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadAsAsync<IEnumerable<Contact>>();
                    data.Wait();
                    var contacts = data.Result;
                    return View(contacts.ToList());
                }
                else
                    return NoContent();
            }
        }
    }
}
