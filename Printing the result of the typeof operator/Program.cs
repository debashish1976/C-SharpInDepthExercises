using System;
using System.Collections.Generic;

namespace Printing_the_result_of_the_typeof_operator
{
    class Program
    {
        static void PrintType<T>()
        {
            //Prints both typeof(T) and typeof(List<T>)
            Console.WriteLine("typeof(T) = {0}", typeof(T));
            Console.WriteLine("typeof(List<T>) = {0}", typeof(List<T>));
        }

        static void Main()
        {
            //Calls the method with a type argument of string
            PrintType<string>();
            //Calls the method with a type argument of int
            PrintType<int>();
        }
    }
}
