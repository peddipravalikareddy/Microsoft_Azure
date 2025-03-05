using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Person
    {
        //public string Name{get;set;}
                           //read&write prop (or) Auto implemented property

        private string _accountNumber = "34567";
        public string AccountNumber {
            get => _accountNumber;
            set => _accountNumber = value;


        }
    }
}
