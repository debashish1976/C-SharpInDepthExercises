using System;
using System.Collections.Generic;

namespace Copying_elements_from_one_collection_to_another
{
    class Program
    {
        //Method declares a type parameter T and uses it in parameters and return type.
        public static List<T> CopyAtMost<T>(List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);
            // Type parameter used in method body
            List<T> ret = new List<T>(actualCount);
            for (int i = 0; i < actualCount; i++)
            {
                ret.Add(input[i]);
            }
            return ret;
        }

        static void Main()
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(20);

            List<string> names = new List<string>();
            names.Add("Debashish");
            names.Add("Vijay");
            names.Add("Gautam");
            names.Add("Senthil");

            //Call to method using int as the type parameter
            List<int> firstTwo = CopyAtMost<int>(numbers, 2);
            Console.WriteLine(firstTwo.Count);

            //Call to method using string as the type parameter
            List<string> firstThree = CopyAtMost<string>(names, 3);
           // List<string> firstOne = CopyAtMost<string>(numbers, 1);
            Console.WriteLine(firstThree.Count);
        }
    }
}
