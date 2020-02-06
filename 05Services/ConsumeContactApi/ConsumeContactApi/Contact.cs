using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumeContactApi
{
    public enum ContactType
    {
        work,
        personal,
        mobile,
        home
    }
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public ContactType contactType { get; set; }
    }
}
