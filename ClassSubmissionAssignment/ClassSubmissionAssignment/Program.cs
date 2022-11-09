using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputInts part1 = new OutputInts();//instantiate  that class

            Console.WriteLine("Please input a number.");//asking the user for a number to use in the method

            int userNum = Convert.ToInt32(Console.ReadLine());//creating a var that can be used in both of the possible methods

            try
            {
                Console.WriteLine("Please input one more number (this is optional press\"ENTER\" to skip)");//asking for a second number if nothing is entered will jump to the catch block under

                OutputInts.outputTwo(num1: userNum, num2: Convert.ToInt32(Console.ReadLine()));//calling the method and using the user input to pass it two numbers
            }

            catch
            {
                OutputInts.outputTwo(userNum);//calling the method and using the user input to pass it a number 
            }
            int i;//creating a int to be used in my following method
            OutputInts.outputParameter(out i);//calling my method with an out parameter
            Console.WriteLine("After the method is called \"i\" is = {0}", i.ToString());//printing the value of "i" after the method is called

            StaticClass.addTwo(num1: 8, num2: 16);

            Console.ReadLine();
        }
    }
}
