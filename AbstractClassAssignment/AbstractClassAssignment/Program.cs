﻿using System;
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
            Employee one = new Employee();//instantiate an employee object

            one.firstName = "Aaron";//giving the firstName property a string
            one.lastName = "Masse";//giving lastName property a string

            one.SayName();//calling the superclass method from persons class
            Console.Read();
        }
    }
}
