using InheritanceDemo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
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
    internal class Student(int id, string domain)
    {
        public int Id { get; set; }
        public string Domain { get; set; }
        public virtual void DisplayStudentInfo()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Domain: " + Domain);
        }
    }
    class Developer : IWork
    {
        public Developer(string name, int age, int empid)
        {

        }
        public void DoWork()
        {
            Console.WriteLine("Developer is working on code");
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
        public Manager(string name, int age, int empid) : base(name, age)
        {
        }
        public void DoWork()
        {
            Console.WriteLine("Manager is working on code");
        }
        public void Manage()
        {
            Console.WriteLine("Manager is managing the team");
        }
    }
}