using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Serialization
{
    [DataContract]
    class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
        public int age { get; set; }
        [DataMember]
        public decimal Salary { get; set; }
    }

}
