using System.Collections.Generic;

namespace ContactApi.Models
{
    public class ContactStore
    {
        public ISet<Contact> contacts { get; } = new HashSet<Contact>() {
            new Contact(){Id=1, FirstName="Princy",LastName="Kalsi",contactType=ContactType.mobile,Phone="9876543210"},
            new Contact(){Id=2,FirstName="Annei",LastName="Kaur", contactType=ContactType.personal,Phone="1234567890"},
            new Contact(){Id=3,FirstName="Jamey",LastName="Wilson", contactType=ContactType.work,Phone="7890543222"},
            new Contact(){Id=4,FirstName="Fred",LastName="Belotte", contactType=ContactType.work,Phone="999999999999" }
        };
    }
}
