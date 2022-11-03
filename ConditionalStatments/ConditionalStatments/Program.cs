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
