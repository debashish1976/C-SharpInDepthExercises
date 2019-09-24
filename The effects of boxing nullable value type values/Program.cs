using System;

namespace The_effects_of_boxing_nullable_value_type_values
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> noValue = new Nullable<int>();
            object noValueBoxed = noValue; //Boxes a value where HasValue is false
            Console.WriteLine(noValueBoxed == null); //Prints True: the result of boxing is a null reference.

            Nullable<int> someValue = new Nullable<int>(5);
            object someValueBoxed = someValue; //Boxes a value where HasValue is true
            Console.WriteLine(someValueBoxed.GetType()); //Prints System.Int32: the result is a boxed int

            Nullable<int> noValueNew = new Nullable<int>();
            //Console.WriteLine(noValueNew.GetType());  //Would throw NullReferenceException

            Nullable<int> someValueNew = new Nullable<int>(5);
            Console.WriteLine(someValueNew.GetType()); //Prints System.Int32, the same as if you’d used typeof(int)
        }
    }
}
