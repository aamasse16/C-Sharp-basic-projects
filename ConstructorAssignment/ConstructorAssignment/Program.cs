using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string str = "string";//create a const variable

            var num1 = 1;//create a var using the keyword "var"

        }
    }
    class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;
        
        public Pizza()//here is an example of constructor overloading
        {
        }

        public Pizza(string bread)
        {
            this.bread = bread;
        }

        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }

        public Pizza(string bread, string sauce, string cheese): this(cheese, "mozzarella")//and this line is constructor chaining
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}
