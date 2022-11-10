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
            Employee emp1 = new Employee();
            emp1.firtName = "Aaron";
            emp1.lastName = "Masse";
            emp1.Id = 1;

            Employee emp2 = new Employee();
            emp2.firtName = "Aaron";
            emp2.lastName = "Masse";
            emp2.Id = 1;

            if (emp1 == emp2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are the same.");
            }
            Console.Read();
        }
    }
}
