using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to be added.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            mathAddition part1 = new mathAddition();

            int number = part1.addNumber(userNum);

            Console.WriteLine(number);


            Console.ReadLine();
        }  
    }
}
