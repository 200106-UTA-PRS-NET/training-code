using System;
using System.Collections.Generic;
using System.Linq;
using JsonSerialization;


namespace Serialization
{
    class Program
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
               new Employee()// anonymous types
               {
                    Id=1,
                    firstName="Cameron",
                    lastName="Coley",
                    age=27,
                    Salary=6000.00M
               },
               new Employee()
               {
                   Id=2,
                    firstName="Kevin",
                    lastName="Tran Huu",
                    age=25,
                    Salary=7000.00M
               },
               new Employee()
               {
                   Id=3,
                    firstName="Fred",
                    lastName="Belotte",
                    age=45,
                    Salary=11000.00M
               }
            };
            return employees;
        }
        static void Main(string[] args)
        {
            //Child child = new Child();
            //new keyword hides the implementation of the parent class method
            //child.DoSomething();
            //child.Test();
            //GrandParent gp = new Child();
            //gp.Test();


            /// Anonymous Methods
            /// 
            Action action = delegate()
            {
                Console.WriteLine("Hello Anonymous");
            };
           // action();
            // Lambda Expression
            Action del = () => Console.WriteLine("Hello Lambda");
            //del();
            // Lambda Statements
            Action del2 = () =>
             {
                 Console.WriteLine("Hello");
                 Console.WriteLine("Lambda");
             };
            //del2();

            // Language Integrated Query - C# syntax to query any data source (arrays, collections, xml, database)
            // Query Syntax
            int[] marks = new int[] {45, 76, 87 , 98, 56, 99 };
            var query = from mark in marks// mandatory 
                        where mark>90 // optional
                        orderby mark descending // optional
                        select mark; //mandatory
            //Console.WriteLine(query.First());

            var emp = (from e in GetEmployees()
                          // where e.Salary>5000.00M && e.age>27
                          //where e.firstName.Contains('K')
                      where e.Salary>5000.00M
                      select e).Count();
            
            // Method Syntax
            var emp1 = GetEmployees().Where(x => x.age == 27).FirstOrDefault();
            // Console.WriteLine(emp1.firstName);
            // Console.WriteLine(emp);
            //foreach (var e in emp)
            //{
            //    Console.WriteLine($"{e.firstName} {e.lastName}");
            //}
            Console.WriteLine("_-------------Serilizing data-----------------");
            Console.WriteLine(JsonHelper<Employee>.Serialize<Employee>(emp1));
            Console.WriteLine("_-------------DeSerializing data-----------------");
            Employee employee=JsonHelper<Employee>.Deserialize<Employee>(JsonHelper<Employee>.Serialize<Employee>(emp1));
            Console.WriteLine(employee.age);
        }
    }
}
