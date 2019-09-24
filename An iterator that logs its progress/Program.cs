using System;
using System.Collections.Generic;

namespace An_iterator_that_logs_its_progress
{
    class Program
    {
        static void Main()
        {
            //foreach (string value in Iterator())
            //{
            //    Console.WriteLine("Received value: {0}", value);
            //}
            //Breaking out of a foreach loop by using an iterator
            foreach (string value in Iterator())
            {
                Console.WriteLine("Received value: {0}", value);
                if (value != null)
                {
                    break;
                }
            }
        }
        static IEnumerable<string> Iterator()
        {
            try
            {
                Console.WriteLine("Before first yield");
                yield return "first";
                Console.WriteLine("Between yields");
                yield return "second";
                Console.WriteLine("After second yield");
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }
    }
}
