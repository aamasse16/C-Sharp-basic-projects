using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee();

            one.firstName = "Aaron";
            one.lastName = "Masse";

            one.SayName();
            Console.Read();
        }
    }
}
