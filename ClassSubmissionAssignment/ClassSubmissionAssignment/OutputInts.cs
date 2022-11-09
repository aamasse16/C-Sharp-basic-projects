using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class OutputInts
    {
        public static void outputTwo(int num1)//created void method that outputs an int taking in a single int
        {
            

            int num2 = num1 / 2;//using the single int passed to the method and dividing it by 2

            Console.WriteLine("The number you gave divided by 2 = " + num2);//printing the result of the previous step with some text
        }

        public static void outputTwo(int num1,int num2)//created void method that outputs an int taking in two ints(this is my overloaded method)
        {


            int num3 = (num1 + num2) / 2;//using the 2 ints passed to the program adding them and then dividing by 2

            Console.WriteLine("The two numbers you gave added together and divided by 2 = " + num3);//printing the result of the previous step with some text
        }

        public static void outputParameter(out int i)
        {
            i = 1;
        }


    }
}
