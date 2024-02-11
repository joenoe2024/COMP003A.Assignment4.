/*
 * author: joseph sandoval
 * course: intro to prog concepts method c#
 * purpose: looping statements
 */

using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace COMP003A.Assignment4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("For loop section");
            Console.WriteLine("output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.WriteLine(" Please enter a positive whole number:  "); string userInput;

            int limit = int.Parse(Console.ReadLine());

            string output = "#";

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));

            string[] simpleArray = new string[] { "rachel", "joey", "chandler", "Ross", "Monica", "phoebe", };

            foreach (var item in simpleArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0;

            do while (counter <= 50)
                {
                    Console.WriteLine(counter);
                    counter += 5;
                } while (counter == 50);

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while section");
            Console.WriteLine("output 1-20");
            Console.WriteLine("if the number is divisible by 2, output foo");
            Console.WriteLine("if the number is divisible by 5, output bar");
            Console.WriteLine("if the number is divisible by 2 & 5, output foobar");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 1;
            
            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }
            











        }
    }
}
