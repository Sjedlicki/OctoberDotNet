using System;
using System.Collections.Generic;

namespace Day_9___Classes_Properties_and_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Classmate> classmates = new List<Classmate>
            {
                new Classmate("Bill","Buffalo","Buffalo Chicken Wings","Football", 7),
                new Classmate("Stitch","Hawaii","All of it","Finding his family", 626),
                new Classmate("Oliver", "Whales", "Crepes", "Playing the banjo", 4)
            };

            foreach(Classmate classmate in classmates)
            {
                classmate.PrintInformation();
                Console.WriteLine();
            }
        }
    }
}
