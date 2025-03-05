//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Employee
//    {
//        public void display()
//        {
//            Console.WriteLine("Employee Display");
//        }

//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        int empId;
        string name, designation, location;
        double salary;
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter Employee Id, Name, Designation, Location, Salary");
            empId = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            designation = Console.ReadLine();
            location = Console.ReadLine();
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + empId);
            //Console.WriteLine($"Employee Id: {empId}");
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Designation: " + designation);
            Console.WriteLine("Employee Location: " + location);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }
}