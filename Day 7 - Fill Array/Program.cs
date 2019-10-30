using System;

namespace Day_7___Fill_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int offSet = 1;
            int arrayLength = ParseInteger("Enter number of Countries: ");

            string[] countries = new string[arrayLength];

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = GetUserInput($"Country {i + 1}: ");
            }

            DisplayArray(countries);

            int index = ValidateRange("Select a Country: ", offSet, countries.Length) - offSet;

            Console.WriteLine($"You're visiting {countries[index]}");
        }

        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int ParseInteger(string message)
        {
            try
            {
                return int.Parse(GetUserInput(message));
            }
            catch
            {
                return ParseInteger(message);
            }
        }

        public static int ValidateRange(string message, int min, int max)
        {
            int userNumber = ParseInteger(message);

            if (userNumber >= min && userNumber <= max)
            {
                return userNumber;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid range please select between {min} - {max}");
            Console.ResetColor();

            return ValidateRange(message, min, max);
        }

        public static void DisplayArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {array[i]}");
            }
        }
    }
}
