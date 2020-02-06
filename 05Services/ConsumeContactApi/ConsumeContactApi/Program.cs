using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ConsumeContactApi
{
    class Program
    {
        static void Main(string[] args)
        {

            using (HttpClient client =new HttpClient())
            {
                string url = "https://localhost:44342/api/contact";
                client.BaseAddress= new Uri(url);
                var response=client.GetAsync("contact");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    Console.WriteLine("Successfully fetched the data");
                    var contacts=result.Content.ReadAsAsync<IEnumerable<Contact>>();
                    contacts.Wait();
                    foreach (var contact in contacts.Result)
                    {
                        Console.WriteLine($"{contact.Id} {contact.FirstName} {contact.LastName} {contact.Phone}");
                    }
                }
            }
        }
    }
}
