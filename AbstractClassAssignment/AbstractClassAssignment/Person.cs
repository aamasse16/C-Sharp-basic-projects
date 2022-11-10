using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person//making the class abstract means that i can never be instantiated
    {
        public string firstName;//giving the class 2 properties
        public string lastName;

        public virtual void SayName()//creating a method that will print the 2 properties above to the console
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
