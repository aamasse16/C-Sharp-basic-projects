using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 4;

            int add = num1 + num2;
            Console.WriteLine(add);

            int subtract = num1 - num2;
            Console.WriteLine(subtract);

            int multiply = num1 * num2;
            Console.WriteLine(multiply);

            int divide = num1 / num2;
            Console.WriteLine(divide);

            string str1 = "hello, ";

            string str2 = "world!";

            string full = str1 + str2;
            Console.WriteLine(full);

            Console.Read();
        }
    }
}
