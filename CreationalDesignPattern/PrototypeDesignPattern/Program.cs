using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an Instance of Permanent Employee Class
            Employee emp1 = new PermanentEmployee()
            {
                Name = "Siva",
                Department = "IT",
                Type = "Permanent",
                Salary = 22260
            };
            //Creating a Clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();
            // Changing the Name and Department Property Value of emp2 instance, 
            // will not change the Name and Department Property Value of the emp1 instance
            emp2.Name = "Krishna";
            emp2.Department = "Development";
            emp1.ShowDetails();
            emp2.ShowDetails();
            // Creating an Instance of Temporary Employee Class
            Employee emp3 = new TemporaryEmployee()
            {
                Name = "kskr",
                Department = "HR",
                Type = "Temporary",
                FixedAmount = 200000
            };
            //Creating a Clone of the above Temporary Employee
            Employee emp4 = emp3.GetClone();
            // Changing the Name and Department Property Value of emp4 instance, 
            // will not change the Name and Department Property Value of the emp3 instance
            emp4.Name = "reddy";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();

            Console.Read();
        }
    }
}
