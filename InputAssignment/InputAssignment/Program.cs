using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your favorite number.");//ask user for there favorite number
            int favNumber = Convert.ToInt32(Console.ReadLine());//assigning the user input to the int "favNumber"

            using (StreamWriter file = new StreamWriter(@"C:\Users\Aaron\logs\log.txt"))//using system.IO and streamwriter to give our input a path to write into a text file
            {
                file.WriteLine(favNumber);//telling the streamwriter what to right into the file
            }
            File.ReadAllText(@"C:\Users\Aaron\logs\log.txt");//reading the text from the file and putting it back onto the console
            Console.Read();
        }
    }
}
