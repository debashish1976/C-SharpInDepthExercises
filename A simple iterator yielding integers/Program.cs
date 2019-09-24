using System;
using System.Collections.Generic;

namespace A_simple_iterator_yielding_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (int value in CreateSimpleIterator())
            //{
            //    Console.WriteLine(value);
            //}
            //The expansion of foreach loop

            IEnumerable<int> enumerable = CreateSimpleIterator(); //Calls the iterator method
            using (IEnumerator<int> enumerator = //Gets an IEnumerator<T> from an IEnumerable<T>
    enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext()) //Moves to the next value, if there is one
                {
                    int value = enumerator.Current; //Fetches the current value
                    Console.WriteLine(value);
                }
            }
        }
        static IEnumerable<int> CreateSimpleIterator()
        {
            yield return 10;
            for (int i = 0; i < 3; i++)
            {
                yield return i;
            }
            yield return 20;
        }
    }
}
