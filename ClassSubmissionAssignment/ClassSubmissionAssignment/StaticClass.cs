using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    static class StaticClass//creating a static class
    {
        public static void addTwo(int num1, int num2)//creating a method in my static class
        {
            int num3 = num1 + num2;//adding the 2 numbers passed to the addTwo method and setting num3 = to the sum

            Console.WriteLine("The 2 numbers you passed added together = " + num3);
        }
    }
}
