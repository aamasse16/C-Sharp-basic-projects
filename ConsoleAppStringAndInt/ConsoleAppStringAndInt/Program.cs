using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringAndInt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() {4, 6, 8, 10};//initializing a list of ints

            try//try block of code
            {
                Console.WriteLine("Please give me a number.");//asking for user input
                int number = Convert.ToInt32(Console.ReadLine());//assigning user input to "number"

                foreach (int num in intList)//each element in the list will have the following code executed on it
                {
                    int dividedNumber;//new int to be used for each element
                    dividedNumber = num / number;//new int will be set = to num / number
                    Console.WriteLine(dividedNumber);//print each dividedNumber to the console
                }
            }
            catch (FormatException ex)//exception if an int isnt passed from the user
            {
                Console.WriteLine("Please input an integer");
            }
            catch (DivideByZeroException ex)//exception if the user inputs a 0
            {
                Console.WriteLine("Please dont input a 0");
            }
            Console.Read();
        }
    }
}
