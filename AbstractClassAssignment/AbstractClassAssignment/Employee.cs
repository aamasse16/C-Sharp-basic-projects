using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person//inheriting from person
    {
        public override void SayName()//using a methond from the inherited class
        {
            base.SayName();
        }
    }
}
