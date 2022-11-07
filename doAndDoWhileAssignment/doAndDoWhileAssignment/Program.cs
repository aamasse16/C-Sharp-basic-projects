using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAndDoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;//declaring var i as an int and setting it to 0
            while (i < 5)//while i is less than 5 do the following
            {
                Console.WriteLine(i);//print i to the console 
                i++;//increment i
            }

            int j = 0;//declaring j as an int and setting it to 0
            do// do the following
            {
                Console.WriteLine(j);//print j to the console
                j++;//increment j
            }
            while (j < 6);//while j is less than 6
            Console.ReadLine();
        }
    }
}
