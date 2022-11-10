using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite day of the week.");//asking user for input

            string userDay = Console.ReadLine();//assigning userDay to user input
            try//try this 
            {
                Day favDay = (Day)Enum.Parse(typeof(Day), userDay.ToLower());//assigning the variable userday to the enum and checking to see if it matches 
                                                                             //one of the enum values 
                Console.WriteLine(favDay);//finally printing the enum value if it matched in the above code if not an error will be thrown
                Console.Read();
            }
            catch//if the try fails print this
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.Read();
            }
        }
        public enum Day//creating a enum called Day
        {
            monday,//giving enum values
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
