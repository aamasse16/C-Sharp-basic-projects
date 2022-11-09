using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number to perform an operation on.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            MathOperation add = new MathOperation();//creating an instance of the mathOperation class

            int number = add.addNum(userNum);//using my new class and the method in the class to get a new number

            Console.WriteLine("Your number plus five = " + number);//printing the output to the console with some text

            Console.WriteLine("Please give me a decimal to perform an operation on.");
            decimal userDec = Convert.ToDecimal(Console.ReadLine());

            int number2 = add.addNum(userDec);//using the same class instance and the same method name to do my second operation

            Console.WriteLine("Your decimal divided by two and rounded down = " + number2);//printing the output to the console with text

            Console.WriteLine("Please give me one more number to multiply");//ask user for one last number
            string userString = Console.ReadLine();//get number from user and assign it to userString

            string multipliedString = add.addNum(userString);//calling method and giving it userString to compute

            Console.WriteLine("Your number times 2 = " + multipliedString);//retun new number and some text to the console

            Console.Read();


        }
    }
}
