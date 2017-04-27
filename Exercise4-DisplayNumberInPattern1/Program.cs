using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_DisplayNumberInPattern1
{
    class Program
    {
        //Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces),
        //and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (i % 2 == 0)
                        Console.Write("{0} ", number);
                    else
                        Console.Write(number);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
