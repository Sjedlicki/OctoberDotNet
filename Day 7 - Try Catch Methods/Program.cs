using System;

namespace Day_7___Try_Catch_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"|{"Interpolate This!", -30}|{"Interpolate That!", 30}|");
            ParseString("Enter a number: ");
        }

        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int ParseString(string message)
        {
            try
            {
                string response = GetUserInput(message);
                int parsedResponse = int.Parse(response);
                return parsedResponse;
            }
            catch
            {
                return ParseString(message);
            }
        }
    }
}
