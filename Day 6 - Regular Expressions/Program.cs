using System;
using System.Text.RegularExpressions;

namespace Day_6___Regular_Expressions
{
    class Program
    {
        private static string namePattern = @"[A-Z][a-z]{1,29}";
        private static string emailPattern = @"[a-zA-Z][a-zA-Z0-9]{4,30}[@][a-z]{5,10}[.][a-z]{2,3}";
        private static string phonePattern = @"\d{3}-\d{3}-\d{4}";
        private static string datePattern = @"[0-3][0-9]/[0-3][0-9]/[12][0-9]{3}";
        private static string[] patternsArray = { namePattern, emailPattern, phonePattern, datePattern };

        static void Main(string[] args)
        {
            do
            {
                Display();
                string userInput = Console.ReadLine();

                while (!Regex.IsMatch(userInput, @"^([1]|[2]|[3]|[4]{1})$"))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection!\nSelect [1] [2] [3] [4]");
                    Console.ResetColor();
                    Display();
                    userInput = Console.ReadLine();
                }

                int userSelection = int.Parse(userInput);

                switch (userSelection)
                {
                    case 1:
                        ValidateName();
                        break;
                    case 2:
                        ValidateEmail();
                        break;
                    case 3:
                        ValidatePhone();
                        break;
                    case 4:
                        ValidateDate();
                        break;
                }

            } while (Continue());


        }

        // Displays validation options to user
        public static void Display()
        {
            Console.WriteLine("Select Patterns to Validate!");
            Console.WriteLine("[1] Names");
            Console.WriteLine("[2] Emails");
            Console.WriteLine("[3] Phone Numbers");
            Console.WriteLine("[4] Dates");
        }

        public static void ValidateName()
        {
            Console.WriteLine("Enter name to validate: ");
            string userInput = Console.ReadLine();

            while(!TestingOnTheReg(userInput, patternsArray[0]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Name. Must begin with a capital letter and be no more than 30 characters long");
                Console.ResetColor();
                userInput = Console.ReadLine();
            }

            Console.WriteLine("The pattern was valid!");
        }

        public static void ValidateEmail()
        {
            Console.Write("Enter email to validate: ");
            string userInput = Console.ReadLine();

            while(!TestingOnTheReg(userInput, patternsArray[1]))
            {
                Console.WriteLine("Invalid email. Must be (5-30 chars)[@](5-10 chars)[.](2-3 chars)");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("The pattern was valid!");
        }

        public static void ValidatePhone()
        {
            Console.Write("Enter phone number to validate: ");
            string userInput = Console.ReadLine();

            while (!TestingOnTheReg(userInput, patternsArray[2]))
            {
                Console.WriteLine("Invalid email. Must be (999-999-9999) format");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("The pattern was valid!");
        }

        public static void ValidateDate()
        {
            Console.Write("Enter date to validate: ");
            string userInput = Console.ReadLine();

            while (!TestingOnTheReg(userInput, patternsArray[3]))
            {
                Console.WriteLine("Invalid email. Must be (dd/mm/yyyy)");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("The pattern was valid!");
        }

        public static bool TestingOnTheReg(string input, string pattern)
        {
            if(Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public static bool Continue()
        {
            Console.Write("Validate More? (y/n): ");
            string userResponse = Console.ReadLine().ToLower();

            if(userResponse == "y" || userResponse == "yes")
            {
                Console.Clear();
                return true;
            }
            else if (userResponse == "n" || userResponse == "no")
            {
                Console.WriteLine("Thanks for validating with us!");
                Console.WriteLine("Good Bye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand that input");
                return Continue();
            }
        }
    }
}
