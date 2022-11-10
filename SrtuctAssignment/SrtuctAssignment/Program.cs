using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrtuctAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number newNumber = new Number
            {
                Amount = Convert.ToDecimal(1.4343)
            };

            Console.WriteLine(newNumber.Amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
