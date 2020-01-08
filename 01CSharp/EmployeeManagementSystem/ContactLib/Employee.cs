using System;

namespace ContactLib
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("calling person class constructor");
        }
    }
    public class Employee:Person
    {
        public int Id { get; set; }
        public Contact contact { get; set; }
        // numbers datatypes
        // byte, int, long
        // 1 byte, 4 byte, 8 bytes
        // float, double, decimal (monetary)
        // 4 bytes, 8 bytes, 16/8 bytes
        protected decimal salary;
        protected float bsal;
        protected float hra;
        protected float tax;
        protected float medical;
        protected float bonus;

        public decimal GetSalary()
        {
            tax = 0.3f * bsal;
            return salary = Convert.ToDecimal(bsal + hra + bonus - tax - medical);
        }

        //default constructor
        public Employee()
        {
            bsal = 5000.00f;
            hra = 2000.00f;
            medical = 200.00f;
            bonus = 550.00f;
            Id = 111;
            Console.WriteLine("Default constructor of Employee class");
        }
        //parameterized constructor
        public Employee(float bsal, float hra, float bonus, float medical, int id)
        {
            this.bsal = bsal;
            this.hra = hra;
            this.bonus = bonus;
            this.medical = medical;
            this.Id = id;
            Console.WriteLine("Parameterized constructor of Employee class");
        }
    }
}
