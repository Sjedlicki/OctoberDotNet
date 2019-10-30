using System;
using System.Globalization;

namespace Day_4___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPart = "This is the first part, ";
            string secondPart = "this is the second part.";

            string together = string.Concat(firstPart, secondPart );
            Console.WriteLine(together);

            bool isEqual = together.Equals("This is not a string");

            Console.WriteLine($"{together} equals \"This is not a string\": {isEqual}");

            int isSame = string.Compare("Cat", "Dog");
            Console.WriteLine($"Cat == Dog: {isSame}");

            isSame = string.Compare("Dog", "Cat");
            Console.WriteLine($"Dog == Cat: {isSame}");

            int index = together.IndexOf("is");
            Console.WriteLine($"IndexOF Expected: 2, Actual: {index}");

            index = together.LastIndexOf("is");
            Console.WriteLine($"LastIndexOf Expected: 29, Actual {index}");

            bool endsWith = together.EndsWith("T", ignoreCase:true, culture:null);
            Console.WriteLine($"EndsWith: Expected: True, Actual: {endsWith}");

            string newTogether = together.Replace("This ", null);
            Console.WriteLine(newTogether);

            string[] togetherArray = together.Split(' ');
            foreach(string word in togetherArray)
            {
                Console.WriteLine(word);
            }

            index = together.LastIndexOf("this");

            string newString = together.Substring(3, 6);
            Console.WriteLine($"Substring is: {newString}");

            string shortString = together.Substring(index);
            Console.WriteLine(shortString);
        }
    }
}