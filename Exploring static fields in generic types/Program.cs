using System;

namespace Exploring_static_fields_in_generic_types
{
    class GenericCounter<T>
    {
        //One field per closed, constructed type
        private static int value;                   

    static GenericCounter()
        {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
        }

        public static void Increment()
        {
            value++;
        }

        public static void Display()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
        }
    }

    class GenericCounterDemo
    {
        static void Main()
        {
            //Triggers initialization for GenericCounter<string>
            GenericCounter<string>.Increment();
            GenericCounter<string>.Increment();
            GenericCounter<string>.Display();

            //Triggers initialization for GenericCounter<int>
            GenericCounter<int>.Display(); 
            GenericCounter<int>.Increment();
            GenericCounter<int>.Display();
        }
    }
}
