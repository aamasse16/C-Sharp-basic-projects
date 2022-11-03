using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please provide us with the weight of the package.");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            if (packageWeight < 50)
            {
                Console.WriteLine("Please provide us with the width of the package.");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please provide us with the height of the package.");
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please provide us with the length of the package.");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());

                decimal dimensionsTotal = packageWidth + packageLength + packageHeight;

                if (dimensionsTotal < 50)
                {
                    decimal quote = packageHeight * packageLength * packageWidth * packageWeight / 100;

                    Console.WriteLine("The estimated total for shipping is: $" + quote);
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }


            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            Console.Read();
        }
    }
}
