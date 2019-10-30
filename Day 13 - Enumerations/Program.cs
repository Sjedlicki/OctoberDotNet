using System;

namespace Day_13___Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            //var day = (int)Days.Friday;

            var day = Enum.GetName(typeof(Days), 4);

   

            Console.WriteLine(day);
        }
    }
}
