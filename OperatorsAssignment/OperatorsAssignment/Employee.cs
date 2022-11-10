using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public string firtName { get; set; }//creating 3 properties fro the employee class
        public string lastName { get; set; }
        public int Id { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)//overloading == operator
        {
            if (emp1.Id.Equals(emp2.Id))//checks to see if emp1 Id and emp2 Id are equal
            {
                return true;//if the above campairison checks out then do this
            }
            return false;//otherwise do this
        }
        public static bool operator !=(Employee emp1, Employee emp2)//overlaoding != operator
        {
            if (!emp1.Id.Equals(emp2.Id))//checks to see if the emp1 and emp2 Id are not equal
            {
                return true;//if the above code checks out then do this
            }
            return false;//otherwise do this
        }
    }

}
