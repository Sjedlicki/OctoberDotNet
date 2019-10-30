using System;

namespace Day_4___ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = CountLetter("Ali Ababwa");

            Console.WriteLine($"Expexted 4: Actual: {count}");
        }

        public static int CountLetter(string sentence)
        {
            int count = 0;

            foreach (char letter in sentence.ToLower())
            {
                if (letter == 'a')
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountLetter(string word, char findLetter)
        {
            int count = 0;

            foreach (char letter in word.ToLower())
            {
                if (letter == findLetter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
