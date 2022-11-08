using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[5];//initializing string array
            stringArray[0] = "Carnduff";//giving the array 5 idicies with 5 dif values
            stringArray[1] = "Zach";
            stringArray[2] = "Aaron";
            stringArray[3] = "Alex";
            stringArray[4] = "Luis";

            Console.WriteLine("Please pick a number 0-4");//asking the user to give a number

            int userString = Convert.ToInt32(Console.ReadLine());//assigning the value givent to the int "userString"

            if (userString <= 4)//using the in to check if there is a index value for that number
            { 
                Console.WriteLine(stringArray[userString]);//printing the value at the given index
            }

            else
            { 
                Console.WriteLine(userString + " does not exist.");//if the given number is to large then this will be printed
            }
            

            int[] intArray = new int[5];//initializing int array
            intArray[0] = 69;//giving the array 5 idicies with 5 dif values
            intArray[1] = 14;
            intArray[2] = 16;
            intArray[3] = 12;
            intArray[4] = 17;

            Console.WriteLine("Please pick a number 0-4");//asking user for a number again

            int userInt = Convert.ToInt32(Console.ReadLine());//assigning the given number to "userInt"

            if (userInt <= 4)//doing a compairision to make sure the given number will have a corasponding index
            { 
                Console.WriteLine(intArray[userInt]);//printing the index value of the given number if in range 
            }
            else
            { 
                Console.WriteLine(userInt + " does not exist.");//if not in range then this message will be displayed
            }

            List<string> stringList = new List<string>();//initializing a list
            stringList.Add("Aaron");//populating the list
            stringList.Add("Luis");
            stringList.Add("Alex");
            stringList.Add("Zach");

            Console.WriteLine("Please pick a number 0-3");//asking user for a number
            Console.WriteLine(stringList[Convert.ToInt32(Console.ReadLine())]);//using the num given by the user to get a value from the list and print it to the console
            
            Console.Read();
        }
    }
}
