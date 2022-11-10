using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuitTable//inheriting from person
    {
        public override void SayName()//using a methond from the inherited class
        {
            Console.WriteLine(firstName + " " + lastName);//printing to the console the 2 class properties
        }
        public void Quit()//calling the Quit method
        {
        }
    }
}
