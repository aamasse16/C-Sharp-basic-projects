using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Aaron";
            //string quote = "The man said, \"Hello\", Aaron. \nHello on a new line. \n \tHello on a new tab.";
            //string fileName = @"C:\User\Aaron";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("n");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.Read();

            //string name = "Aaron";
            //name = "joe";

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Aaron");

            //Console.WriteLine(sb);
            //Console.Read();

            string a = "Hello, ";//here i create 3 seperate strings
            string b = "my name is ";
            string c = "Aaron.";

            string abc = a + b + c;//here i concatenate the 3 strings
            string ABC = abc.ToUpper();//here i use the .ToUpper() to make the whole string upper case 

            StringBuilder sb = new StringBuilder();//creating a string builder object
            sb.Append("Hello, world!");//these 3 lines im using .Append to add to my string "sb"
            sb.Append(" My name is Aaron.");
            sb.Append(" And this is my string using C#s StringBuilder.");
            Console.WriteLine(sb);//here i print my string builder string "sb" to the console
            Console.WriteLine(ABC);//here i print the whole upper case concatenated string to the console
            Console.Read();

        }
    }
}
