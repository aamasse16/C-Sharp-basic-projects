using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T>//make the class take a generic parameter
    {
        public List<T> things { get; set; }//create generic list
    }
}
