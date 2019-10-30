using System;

namespace Day_7___ForLoop_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "dog", "tiger", "wombat", "emu", "cat", "platypus", "kangaroo", "koala bear", "Huntsman Spider" };
            DisplayArray(animals);
        }

        public static void DisplayArray(string[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}