using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ContactSoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceContact" in both code and config file together.
    [ServiceContract]
    public interface IServiceContact
    {
        [OperationContract]
        List<ContactData> GetContacts();
        [OperationContract]
        void AddContact(ContactData contactData);
    }

    [DataContract]
    public class ContactData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string fullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
            set{ }
        }

    }
}
