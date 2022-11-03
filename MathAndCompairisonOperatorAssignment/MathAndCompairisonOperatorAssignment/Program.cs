using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndCompairisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //welcoming to the program
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1 please tell us your hourly rate");
            decimal personOneHourlyRate = Convert.ToDecimal(Console.ReadLine()); //declairing variables
            Console.WriteLine("Person 1 please tell us how many hours you work a week");
            decimal personOneHoursWorked = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 1 \nHourly Rate: " + personOneHourlyRate + "\nHours Worked per week: " + personOneHoursWorked);//using variables with string concatenation

            Console.WriteLine("Person 2 please tell us your hourly rate");
            decimal personTwoHourlyRate = Convert.ToDecimal(Console.ReadLine());//declaring variables
            Console.WriteLine("Person 2 please tell us how many hours you work a week");
            decimal personTwoHoursWorked = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Person 2 \nHourly Rate: " + personTwoHourlyRate + "\nHours Worked per week: " + personTwoHoursWorked);//using variables with string concatenation

            decimal personOneSalary = personOneHourlyRate * personOneHoursWorked * 52; //using the above variables to calculate each persons salary

            decimal personTwoSalary = personTwoHourlyRate * personTwoHoursWorked * 52;

            Console.WriteLine("Annual salary of Person 1: " + personOneSalary);//using string concatenation to display the salarys with some text
            Console.WriteLine("Annual salary of Person 2: " + personTwoSalary);

            bool whoMakesMore = personTwoSalary > personOneSalary;//using boolean logic to compair the 2 slaries

            Console.WriteLine("It is " + whoMakesMore + " that person two makes more than person one in a year."); //using string concatenation and the boolean varible to tell who makes more in a year

            Console.Read();
        }
    }
}
