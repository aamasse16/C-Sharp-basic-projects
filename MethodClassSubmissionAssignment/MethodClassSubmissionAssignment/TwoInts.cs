using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    class TwoInts
    {
        public static void takeTwo(int num1, int num2)//creating a method in my new class
        {
            int num3 = num1 + 16;//using one of the 2 ints passed to the method to add 16 to it and assigning it a new int named num3

            Console.WriteLine("The second number you inputed is " + num2);//using the second number passed to the method to print it to the console with some text
        }
    }
}
