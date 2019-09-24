using System;
using System.Collections.Generic;

namespace Generating_and_printing_names_with_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames(GenerateNames());
        }

        /*
         * 1) You don’t need to know the size of the collection beforehand, unlike with arrays.
         * 2) The exposed API uses T everywhere it needs to refer to the element type, so you know that a List<string> will contain only string references. You’ll get a compile-time error if you try to add anything else, unlike with ArrayList.
         * 3) You can use it with any element type without worrying about generating code and managing the result, unlike with StringCollection and similar types.
         */

        static List<string> GenerateNames()
        {
            List<string> names = new List<string>();
            names.Add("Vijay");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
           // names.Add(1);
            return names;
        }

        static void PrintNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
