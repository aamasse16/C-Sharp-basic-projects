using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input your age.");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("So you are " + userAge + " years old?");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input a positive number for your age.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred, please try again.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
