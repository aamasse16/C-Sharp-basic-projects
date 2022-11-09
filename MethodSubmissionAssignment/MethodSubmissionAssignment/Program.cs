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

                Console.WriteLine("Please give a second number.");
                int userNum2 = Convert.ToInt32(Console.ReadLine());

                twoInts newNums = new twoInts();

                int number = newNums.addNumbers(userNum, userNum2);
                Console.WriteLine("Your two number added and multiplied by 2 = " + number);
            }
            catch
            {
                int userNum = Convert.ToInt32(Console.ReadLine());//assigning that number to userNum
                twoInts newNums = new twoInts();

                int number = newNums.addNumbers(userNum);
                Console.WriteLine("Your two number added and multiplied by 2 = " + number);
            }
           

            Console.Read();
        }
    }
}
