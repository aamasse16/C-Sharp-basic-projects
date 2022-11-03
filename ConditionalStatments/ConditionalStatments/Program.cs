using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 24;
            int num2 = 12;

            string result = num1 > num2 ? "Num1 is greater than num2" : "Num2 is greater than num1";
            Console.WriteLine(result);
            

            if (10 <= 9)
            {
                Console.WriteLine("The first number is smaller");
            }
            else
            {
                Console.WriteLine("The second number is smaller");
            }
            Console.ReadLine();
        }
    }
}
