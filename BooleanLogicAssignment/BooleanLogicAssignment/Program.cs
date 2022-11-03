using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");//ask user for age
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (please type 'true' or 'false')");//ask user if they have a dui
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");//ask user how many speeding tickets they have
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            bool qualified = age > 15 && dui == false && speedingTickets <= 3;//use all 3 variables to check if they are qualified if any are false "qualified" will = false

            Console.WriteLine("Qualified: " + qualified);//print "qualified to the console"
            Console.Read();
        }
    }
}
