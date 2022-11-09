using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoInts.takeTwo(73,8);//calling the method and inputting 2 ints not using the parameter names
            TwoInts.takeTwo(num1: 9,num2: 4);//calling method and inputing 2 ints using parameter names

            Console.Read();
        }
    }
}
