using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee number1 = new Employee();
            number1.FirstName = "Sample";
            number1.LastName = "Student";

            number1.SayName();
            Console.Read();
            
        }
    }
}
