using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Aaron", "Alex", "Luis", "Zach" };//initializing string array

            //Console.WriteLine("Please input some text.");//asking user for input
            //string userText = Console.ReadLine();//assigning input from user to "UserText"

            //for (int i = 0; i < names.Length; i++)//for loop to add user text to each array element
            //{
            //    names[i] = names[i] + userText;
            //}
            //for (int i = 0; i < names.Length; i++)//for loop to print each element to the console
            //{
            //    Console.WriteLine(names[i]);
            //}

            ////create infinite loop
            //int p = 0;//added after the infinte loop so that the loop only executes 2 time
            //while (p < 2)//part 3 a loop where the determining factor is "<"
            //{
            //    Console.WriteLine("This loop will only stop when we make it");
            //    p++;//added to make the loop only execute 2 time
            //}

            //int o = 0;//used to iterate the following loop
            //while (o <= 4)//used to make the loop execute 5 times
            //{
            //    Console.WriteLine("this loop will execute 5 times");
            //    o++;
            //}

            ////part 4 list of strings where each item is unique
            //List<string> stringList = new List<string>() {"Aaron", "Luis", "Alex", "Zach"};

            //Console.WriteLine("Please search for a name.");
            //string nameSearch = Console.ReadLine();//gets input from the user and assigns it to "nameSearch"

            //for (int u = 0; u < stringList.Count; u++)//iterates through the list
            //{
            //    if (nameSearch == stringList[u])//if statment will only execute if the user input matches the value at that index spot
            //    {
            //        Console.WriteLine("That name is in the index spot" + stringList.IndexOf(nameSearch));
            //        break;
            //    }

            //    else//will execute if the user input doesnt match the value in the List
            //    {
            //        Console.WriteLine("This name does not exist in this spot");
            //    }
            //}

            ////part 5 
            //List<string> identicalStrings = new List<string>() {"odd", "even", "odd", "even"};//initializing list

            //Console.WriteLine("Please pick: odd or even?");//asking for user input
            //string userPick = Console.ReadLine();

            //for (int j = 0; j < identicalStrings.Count; j++)//loop for iterating through the list
            //{
            //    if (userPick == identicalStrings[j])//conditional statement to change the output based on the input
            //    {
            //        Console.WriteLine("Your word is here " + identicalStrings[j]);//writes to the console some text and the users pick location on the list
            //    }
            //    else if (userPick != identicalStrings[j])//if the user pick is not equal to a element in the list this is executed
            //    {
            //        Console.WriteLine("Your input is not in this List");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your word is not in this spot");
            //    }
            //}

            //part 6
            List<string> strings = new List<string>() {"Aaron", "Alex", "Aaron", "Alex", "Luis", "Zach"};
            List<string> dupStrings = new List<string>();



            foreach (string str in strings)
            {
                

                if (str.Contains(str) && dupStrings.Contains(str))
                {
                    Console.WriteLine(str + " - This is a duplicate");
                }
                else
                {
                    Console.WriteLine(str + " - This is unique");
                }
                dupStrings.Add(str);
            }
            Console.Read();
        }
    }
}