using System;
using System.Collections.Specialized;

namespace Generating_and_printing_names_by_using_StringCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames(GenerateNames());
        }
        static StringCollection GenerateNames()
        {
            //Much better than previous solutions. But how many specialized collections will you write?
            StringCollection names = new StringCollection();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            //names.Add(1);
            return names;
        }

        static void PrintNames(StringCollection names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
