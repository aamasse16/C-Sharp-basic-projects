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
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            decimal personOneHourlyRate = 15.00m;
            decimal personOneHoursWorked = 36.00m;
            Console.WriteLine("Person 1 \nHourly Rate: " + personOneHourlyRate + "\nHours Worked per week: " + personOneHoursWorked);

            decimal personTwoHourlyRate = 20.00m;
            decimal personTwoHoursWorked = 25.00m;
            Console.WriteLine("Person 2 \nHourly Rate: " + personTwoHourlyRate + "\nHours Worked per week: " + personTwoHoursWorked);

            decimal personOneSalary = personOneHourlyRate * personOneHoursWorked * 52;

            decimal personTwoSalary = personTwoHourlyRate * personTwoHoursWorked * 52;

            Console.WriteLine("Annual salary of Person 1: " + personOneSalary);
            Console.WriteLine("Annual salary of Person 2: " + personTwoSalary);

            bool whoMakesMore = personTwoSalary > personOneSalary;

            Console.WriteLine("It is " + whoMakesMore + " that person two makes more than person one in a year.");

            Console.Read();
        }
    }
}
