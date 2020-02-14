using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ContactSoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceContact" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceContact.svc or ServiceContact.svc.cs at the Solution Explorer and start debugging.
    public class ServiceContact : IServiceContact
    {
       static List<ContactData> contacts = new List<ContactData>()
      {
          new ContactData(){Id=1,lastName="Test",firstName="Test f", Phone="1234567890"}
      };
        public List<ContactData> GetContacts()
        {
            return contacts;
        }
        public void AddContact(ContactData contactData)
        {
            contacts.Add(contactData);
        }
    }
}
