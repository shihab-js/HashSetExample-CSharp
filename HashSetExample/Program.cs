using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a set of string
            var names = new HashSet<string>();

            names.Add("Shihab");
            names.Add("Mishu");
            names.Add("Rayhan");


            //Iterate the set of elements
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}
