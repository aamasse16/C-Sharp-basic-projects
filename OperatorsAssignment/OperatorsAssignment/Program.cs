using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();//creating a object from employee class
            emp1.firtName = "Aaron";//giving emp1 values
            emp1.lastName = "Masse";
            emp1.Id = 1;

            Employee emp2 = new Employee();//creating a second object from the employee class
            emp2.firtName = "Aaron";//giving emp2 values
            emp2.lastName = "Masse";
            emp2.Id = 1;

            if (emp1 == emp2)//using the overloaded operator to compair emp1 and emp2
            {
                Console.WriteLine("Employee 1 and Employee 2 are the same.");//if the above compairision is true print this
            }

            if (emp1 != emp2)//using the overloaded operator to compair emp1 and emp2
            {
                Console.WriteLine("Employee 1 and Employee 2 are not the same");//if the above compairison is true print this
            }
            Console.Read();
        }
    }
}
