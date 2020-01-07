using System;

namespace ContactLib
{
    public class Contact
    {
        //variables - string, int, byte, double, float, bool, char, DateTime, long
       private string firstName;
       private string lastName;
       private int age;
       private string phone;
       private string email;
       private long id;
        // autonomous property
        public bool IsFullTime { get; set; }

        // properties - smart fields which are used to provide public access to a private variable
        public string FirstName
        {
            get// allows you to read the private value
            {
                return firstName;
            }
            // comment - select the code ctrl + K+C
            // uncomment - select code and Ctrl + K + U
            set// allows you to write that private variable
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get// allows you to read the private value
            {
                return lastName;
            }
            set// allows you to write that private variable
            {
                lastName = value;
            }
        }
        public string GetEmployee(string firstName, string lastName, int age, string phone, string email, long id)
        {
            // this points to current member of the current class
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.phone = phone;
            this.email = email;
            this.id = id;

            return $"Name - {firstName} {lastName} \n Age - {age} \n Phone - {phone} \n Email - {email} \n Emp Id- {id}";
        }
        //Constructor - ctor + <tab> + <tab>
        public Contact()
        {
            firstName = "Nick";
            lastName = "Escalona";
            phone = "9876543211";
        }
    }
}
