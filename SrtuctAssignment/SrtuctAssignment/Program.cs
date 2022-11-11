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
            Number newNumber = new Number//create an object of data type Number
            {
                Amount = Convert.ToDecimal(1.4343)//assign it an amount
            };

            Console.WriteLine(newNumber.Amount);//print new amount to console
            Console.ReadLine();
        }
        public struct Number//create struct with property "Amount"
        {
            public decimal Amount { get; set; }
        }
    }
}
