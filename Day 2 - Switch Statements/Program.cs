using System;

namespace Day_2___Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ordering = true;
            while (ordering)
            {
                Console.WriteLine("Welcome to the GC Burger Shop");
                Console.WriteLine("1. Cheeseburger");
                Console.WriteLine("2. Deluxe Cheeseburger");
                Console.WriteLine("3. Royale with Cheese");
                Console.WriteLine("4. Checkout");

                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "1": case "cheeseburger":
                        Console.WriteLine("You selected the Cheeseburger!");
                        break;
                    case "2": case "deluxe cheeseburger":
                        Console.WriteLine("You selected the Deluxe Cheeseburger");
                        break;
                    case "3": case "royale with cheese":
                        Console.WriteLine("It's called the Royale with cheese");
                        break;
                    case "4": case "checkout":
                        Console.WriteLine("Check it out!");
                        Console.WriteLine("Check it out!");
                        Console.WriteLine("Check it out!");
                        Console.WriteLine("Check it out!");
                        Console.WriteLine("Check it out!");
                        ordering = false;
                        break;
                    default:
                        Console.WriteLine("You didn't make a valid selection!");
                        break;
                }
            }

            Console.WriteLine("Thank you for ordering. Goodbye.");
        }
    }
}