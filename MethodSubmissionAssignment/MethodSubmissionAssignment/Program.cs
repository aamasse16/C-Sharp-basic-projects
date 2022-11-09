using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input a number to be added.");//asking user for a number
                int userNum = Convert.ToInt32(Console.ReadLine());//assigning that number to userNum

                Console.WriteLine("Please give a second number.");//getting second number
                int userNum2 = Convert.ToInt32(Console.ReadLine());//assigning second number to userNum2

                twoInts newNums = new twoInts();//creating an instance of the class

                int number = newNums.addNumbers(userNum, userNum2);//using the method in the class to add 2 nubmers and multiply them
                Console.WriteLine("Your two number added and multiplied by 2 = " + number);//returning the number and printing it with text to console
            }
            catch
            {
                Console.WriteLine("Please re-enter your number to be added.");//asking user for a number
                int userNum = Convert.ToInt32(Console.ReadLine());//assigning that number to userNum

                twoInts newNums = new twoInts();//creating an instance of the class

                int number = newNums.addNumbers(userNum);//using the method in the class to multiply the single number by 2
                Console.WriteLine("Your number multiplied by 2 = " + number);//returning the number and printing it with text to console
            }
           

            Console.Read();
        }
    }
}
