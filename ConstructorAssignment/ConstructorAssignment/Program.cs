using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConstructorAssignment.Person;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Aaron";

            var str = "apples";

            Student Luis = new Student("Luis");
            Console.WriteLine(Luis.firstName + " is the newest student here.");
            Console.Read();
        }
    }
}
