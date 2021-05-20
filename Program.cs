using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementExercise1
{
    class Program
    {
        //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        //Display the count on the console.
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("THere are {0} numbers divisible by 3 between 1 and 100.", count);
        }
    }
}
               

