using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 16;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62 try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29 try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55 try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 16:
                        Console.WriteLine("You guessed 16 that is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();
        }
    }
}
