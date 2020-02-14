using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumeContactService.ContactRef;

namespace ConsumeContactService
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactRef.ServiceContactClient client = new ServiceContactClient();
            var contacts=client.GetContacts();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.firstName} {contact.lastName} {contact.Phone}");
            }
            Console.ReadLine();
        }
    }
}
