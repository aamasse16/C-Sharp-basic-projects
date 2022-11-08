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
            Console.WriteLine("Please input a number to be added.");//asking user for a number
            int userNum = Convert.ToInt32(Console.ReadLine());//assigning that number to userNum

            mathAddition part1 = new mathAddition();//creating a new object using our new class

            int number = part1.addNumber(userNum);//creating a new number that uses a method from our class

            int number2 = part1.subNumber(userNum);//creating a new number that uses a method from our class

            int number3 = part1.multiplyNumber(userNum)//creating a new number that uses a method from our class


            Console.WriteLine("Your number plus 5 = " + number);
            Console.WriteLine("Your number plus 5 = " + number2);
            Console.WriteLine("Your number plus 5 = " + number3);


            Console.ReadLine();
        }  
    }
}
