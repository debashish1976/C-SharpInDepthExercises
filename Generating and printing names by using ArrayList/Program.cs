using System;
using System.Collections;

namespace Generating_and_printing_names_by_using_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames(GenerateNames());          
        }
        static ArrayList GenerateNames()
        {
            //You don't need to know the size
            // But What happens if the ArrayList contains a nonstring?
            ArrayList names = new ArrayList();
            names.Add("Debashish");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
           // names.Add(1);
            return names;
        }
        static void PrintNames(ArrayList names)
        {
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
        }
    }
}
