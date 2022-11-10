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
            Console.WriteLine("Please enter your favorite day of the week.");

            string userDay = Console.ReadLine();

            DaysOfTheWeek day = new DaysOfTheWeek();
            Day favDay = (Day)Enum.Parse(typeof(Day), userDay);

            Console.WriteLine(favDay);
            Console.Read();
        }
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
