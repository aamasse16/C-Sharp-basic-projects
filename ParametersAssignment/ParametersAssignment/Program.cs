using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strings = new Employee<string>();//instantiate employee object with string parameter
            
            Employee<int> ints = new  Employee<int>();//instantiate employee object with int parameter

            ints.things = new List<int>() { 16, 9, 24};//populating the list with ints

            strings.things = new List<string>() { "Apple", "Orange"};//populating the list with strings

            for (int i = 0; i < ints.things.Count();i++)//for loop to iterate through the ints list
            {
                Console.WriteLine(ints.things[i]);//each time it goes through the loop print the current int being worked with
            }

            //foreach (int o in ints.things)
            //{
            //    Console.WriteLine(ints.things[o]);
            //}

            for (int j = 0; j < strings.things.Count(); j++)//for loop to iterate through the ints list
            {
                Console.WriteLine(strings.things[j]);//each time it goes through the loop print the current string being worked with
            }

            Console.ReadKey();
        }
    }
}
