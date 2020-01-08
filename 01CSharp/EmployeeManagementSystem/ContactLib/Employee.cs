using System;

namespace ContactLib
{
    public class Person
    {
        public Person()
        {
           // Console.WriteLine("calling person class constructor");
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
        // Method overloading - method with same name in same class with different Signatures
        /*
         Method Signatures:
            - Number parameters
            - Type of Parameter
            - Sequence of Parameter
        */

        public decimal GetSalary()
        {
            CalculateTax(bsal);
            return salary = Convert.ToDecimal(bsal + hra + bonus - tax - medical);
        }
        // difference in number of parameters
        public decimal GetSalary(float bsal)
        {
            //tax = 0.3f * bsal;
            CalculateTax(bsal);
            return salary = Convert.ToDecimal(bsal + hra + bonus - tax - medical);
        }
        // difference in type of parameters
        public decimal GetSalary(double bsal,float bonus)
        {
            //  tax = 0.3f* Convert.ToSingle(bsal);
            CalculateTax(Convert.ToSingle(bsal));
            return salary = Convert.ToDecimal(bsal + hra + bonus - tax - medical);
        }
        // difference in sequence of parameters
        public decimal GetSalary(float bonus, double bsal)
        {
            //tax = 0.3f * Convert.ToSingle(bsal);
            CalculateTax(Convert.ToSingle(bsal));
            return salary = Convert.ToDecimal(bsal + hra + bonus - tax - medical);
        }
        // Method Overiding - Redefining the method of base class in child class
        protected virtual decimal CalculateTax(float bsal)
        {
            return Convert.ToDecimal(tax = 0.3f * bsal);
        }
       // Abstract method have no definition/implementation where as virtual methods does
       // protected abstract decimal CalculateTax(float bsal);
        //default constructor
        public Employee()
        {
            bsal = 5000.00f;
            hra = 2000.00f;
            medical = 200.00f;
            bonus = 550.00f;
            Id = 111;
            //Console.WriteLine("Default constructor of Employee class");
        }
        //parameterized constructor
        public Employee(float bsal, float hra, float bonus, float medical, int id)
        {
            this.bsal = bsal;
            this.hra = hra;
            this.bonus = bonus;
            this.medical = medical;
            this.Id = id;
            //Console.WriteLine("Parameterized constructor of Employee class");
        }
    }
}
