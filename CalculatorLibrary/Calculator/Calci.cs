using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calci
    {
        int num1, num2;
        public void getNumbers()
        {
            Console.WriteLine("Enter num1 and num2 for calculations: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"num1={num1} \n num2={num2}");
        }
        public void Addition()
        {
            Console.WriteLine($"num1+num2={num1 + num2}");
        }
        public void Subtraction()
        {
            Console.WriteLine($"num1-num2={num1 - num2}");
        }
        public void Multiplication()
        {
            Console.WriteLine($"num1 x num2={num1 * num2}");
        }
    }
}
