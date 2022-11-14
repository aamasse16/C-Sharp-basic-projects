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
            DateTime today = DateTime.Now;

            Console.WriteLine(today);
            Console.WriteLine("Please input a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If we add your number in hours to the current time it would be " + today.AddHours(userNum));

            Console.Read();
        }
    }
}
