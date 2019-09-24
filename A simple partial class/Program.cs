using System;

namespace A_simple_partial_class
{
    partial class PartialDemo
    {
        public static void MethodInPart1()
        {
            MethodInPart2(); //Uses method declaredin second part
        }

        public static void Main()
        {
            MethodInPart1();
        }
    }

    partial class PartialDemo
    {
        private static void MethodInPart2()  //Method used by first part
        {
            Console.WriteLine("In MethodInPart2");
        }
    }
}
