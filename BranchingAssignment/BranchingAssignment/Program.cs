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
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");//welcome text

            Console.WriteLine("Please provide us with the weight of the package.");//get weight of package
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            if (packageWeight < 50)//if package is over 50 weight then end the program if its below 50 continue to get info
            {
                Console.WriteLine("Please provide us with the width of the package.");//get width
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please provide us with the height of the package.");//get height
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please provide us with the length of the package.");//get length
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());

                decimal dimensionsTotal = packageWidth + packageLength + packageHeight;//calculate total dimensions

                if (dimensionsTotal < 50)//check if total dimensions is to large if it is more than 50 end the program if its under 50 continue to quote it
                {
                    decimal quote = packageHeight * packageLength * packageWidth * packageWeight / 100;//calculate the quote

                    Console.WriteLine("The estimated total for shipping is: $" + quote);//print the quote to the screen with some text
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");//message to be displayed of the package dimensions are too large
                }


            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");//message to be displayed if the package weight is to high
            }

            Console.Read();
        }
    }
}
