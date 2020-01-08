using System;
using System.Text;
// import the contactLib
using ContactLib;

namespace ContactUi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Revature EMS*************");
            // Initialize the class or instantiate the object
            Contact contact = new Contact();
            // String Concat - bad practise
            //Console.WriteLine("Default Employee Name "+ contact.firstName+" "+contact.lastName);
            contact.FirstName = "Nicky";
            // use String Builder class instead or string interpolation
            StringBuilder emp = new StringBuilder();// creates mutable string which cane be appended in the same memory location
            emp.Append("----Default Employee Name ----").Append(contact.FirstName).Append(" ").Append(contact.LastName);
            Console.WriteLine(emp);
            string empDetails=contact.GetEmployee("Fred", "Belotte", 40, "9876543211", "fred@revature.com");
            Console.WriteLine(empDetails);

            Employee employee = new Employee(6000,3000,600,300,145);
            Console.WriteLine("Salary of employee {0}", employee.GetSalary());

            Manager manager = new Manager(8000,4000,1000,600,666);
            Console.WriteLine($" Salary of Manager  {manager.GetSalary()}");

        }
    }
}
