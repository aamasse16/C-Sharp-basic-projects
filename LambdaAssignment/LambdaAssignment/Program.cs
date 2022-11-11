using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>() { //instatiating new list and populating it
                new Employee(){ Id = 1, FirstName = "Aaron", LastName = "Masse"},
                new Employee(){ Id = 2, FirstName = "Alex", LastName = "Brady"},
                new Employee(){ Id = 3, FirstName = "Joe", LastName = "Smith"},
                new Employee(){ Id = 4, FirstName = "Zach", LastName = "Berg"},
                new Employee(){ Id = 5, FirstName = "Joe", LastName = "Mad"},
                new Employee(){ Id = 6, FirstName = "Luis", LastName = "Madriz"},
                new Employee(){ Id = 7, FirstName = "Sam", LastName = "Smith"},
                new Employee(){ Id = 8, FirstName = "Jack", LastName = "Paris"},
                new Employee(){ Id = 9, FirstName = "Cam", LastName = "Duncan"},
                new Employee(){ Id = 10, FirstName = "Aryon", LastName = "Starks"}
            };

            //foreach (Employee emp in empList)
            //{
            //    if (emp.FirstName == "Joe")
            //    {
            //        Console.WriteLine(emp.FirstName);
            //    }
            //}

            List<Employee> idList = empList.Where(y => y.Id > 5).ToList();

            foreach (Employee emp1 in idList)
            { 
                Console.WriteLine(emp1.FirstName);
            }
           
            List<Employee> newList = empList.Where(x => x.FirstName == "Joe").ToList();//using lambda expression to pull only the employees with the first name "Joe"
            //into a new list

            foreach (Employee emp in newList)
            {
                Console.WriteLine(emp.FirstName);
            }
            
            Console.ReadLine();
            
        }
    }
}
