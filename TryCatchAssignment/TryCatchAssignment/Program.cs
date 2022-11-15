using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input your age.");//ask user for age
                int userAge = Convert.ToInt32(Console.ReadLine());//assign user input to var userAge
                if (userAge < 0)//if the user inputs a number below 0 the following exception will be thrown
                {
                    throw new FormatException();
                }
                Console.WriteLine("So you are " + userAge + " years old?");//if the above if statment isnt hit then this code will be run
            }
            catch (FormatException)//catch for format exceptions
            {
                Console.WriteLine("Please input a positive number for your age.");
                Console.ReadLine();
                return;
            }
            catch (Exception)//catch for generic exceptions
            {
                Console.WriteLine("An error occurred, please try again.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
