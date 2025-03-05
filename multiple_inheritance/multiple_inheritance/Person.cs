using multiple_inheritance.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance
{
    internal class Person
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    internal class Student : Person
    {
        public int Id { get; set; }
        public string Domain { get; set; }

        public Student(string name, int age, int id, string domain) : base(name, age)
        {
            Id = id;
            Domain = domain;
        }

        public virtual void DisplayStudentInfo()
        {
            DisplayInfo(); // Calling base class method
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Domain: " + Domain);
        }
    }

    class Developer : Person, IWork
    {
        public int EmpId { get; set; }

        public Developer(string name, int age, int empid) : base(name, age)
        {
            EmpId = empid;
        }

        public void DoWork()
        {
            Console.WriteLine("Developer is working on code");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee ID: {EmpId}");
        }
    }

    class Tester : IWork
    {
        public void DoWork()
        {
            Console.WriteLine("Tester is testing the code");
        }
    }

    class Manager : Person, IWork, IManage
    {
        public int EmpId { get; set; }

        public Manager(string name, int age, int empid) : base(name, age)
        {
            EmpId = empid;
        }

        public void DoWork()
        {
            Console.WriteLine("Manager is coordinating with clients");
        }

        public void Manage()
        {
            Console.WriteLine("Manager is managing the team");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee ID: {EmpId}");
        }
    }
}