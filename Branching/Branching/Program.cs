using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string results = favNum == 16 ? "You have an awesome favorite number." : "Your favorite number isnt so awesome.";

            Console.WriteLine(results);
            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + " what is the temp where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhh....something went wrong.");  
            //}

            //int currentTemp = 70;
            //int roomTemp = 70;

            //string compairisonResults = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(compairisonResults);

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temp.");
            //}
            Console.Read();
        }
    }
}
