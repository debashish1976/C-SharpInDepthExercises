using System;

namespace Generating_and_printing_names_by_using_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames(GenerateNames());
            
        }
        static string[] GenerateNames()
        {
            //Size of array needs to be known at creation time
            string[] names = new string[4];
            names[0] = "Gamma";
            names[1] = "Vlissides";
            names[2] = "Johnson";
            names[3] = "Helm";
            return names;
        }

        static void PrintNames(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
