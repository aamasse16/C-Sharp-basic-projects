using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;//created a new date time object called today

            Console.WriteLine(today);//print today to the console (current datetime)
            Console.WriteLine("Please input a number.");//ask user for a number
            int userNum = Convert.ToInt32(Console.ReadLine());//assign user input to the int var userNum

            Console.WriteLine("If we add your number in hours to the current time it would be " + today.AddHours(userNum));//using the user input to add userNum to the current datetime
            //and then printing that future date time to the console
            Console.Read();
        }
    }
}
