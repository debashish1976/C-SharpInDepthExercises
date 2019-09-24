using System;
using System.Collections.Generic;

namespace Iterating_over_the_Fibonacci_sequence
{
    class Program
    {
        static IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;
            while (true) //Infinite loop? Only if you keep asking for more
            {
                yield return current; //Yields the current Fibonacci value
                int oldCurrent = current;
                current = next;
                next = next + oldCurrent;
            }
        }

        static void Main()
        {
            foreach (var value in Fibonacci()) //Calls the method to obtain the sequence
            {
                Console.WriteLine(value); //Prints the current value
                if (value > 100) //Break condition
                {
                    break;
                }
            }
        }
    }
}
