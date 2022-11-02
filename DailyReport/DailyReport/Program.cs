using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {   //intro to the program(greeting)
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            //asks for name and stores it in var "name"
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //ask for current course and stores it in "course"
            Console.WriteLine("What course are you currently working on?");
            string course = Console.ReadLine();
            //ask for the current page number and stores it in "pageNum"
            Console.WriteLine("What is the page number you are on?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            //ask if any help is needed and stores it as string in "needHelp" then converts it to bool and is stored in "help"
            Console.WriteLine("Is there anything you need help with? (please answer \"true\" or \"false\")");
            string needHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needHelp);
            //ask for positive experieces and stores it in "posExperiences"
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();
            //ask for any other feedback and stores it in "feedback"
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            //ask for the number of hours studied and stores it in "hours studied"
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            //says thank you for filling ou the form and says goodbye
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.Read();
            

        }
    }
}
