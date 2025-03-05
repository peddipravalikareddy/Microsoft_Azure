using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OopsDemo
    {
        string name = "";
        public OopsDemo()
        {
            Console.WriteLine("Constructor Called");
        }
        public OopsDemo(string company)
        {
            Console.WriteLine("Constructor Called with Company Name: " + company);
        }
        public OopsDemo(OopsDemo obj)
        {
            Console.WriteLine("Copy Constructor");
            Console.WriteLine(obj.name);
        }
    }
}