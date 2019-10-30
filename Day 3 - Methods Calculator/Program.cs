using System;

namespace Day_3___Methods_Calculator
{
    class Program
    {
        public static bool keepGoing = true;
        static void Main(string[] args)
        {
            decimal number1;
            decimal number2;

            Console.WriteLine("Welcome to the GC Calculator\n");
            // TODO: Write method for retrieving user number.
            number1 = GetUserNumber();

            while (keepGoing)
            {
                PrintMenu();

                string operationSelection = Console.ReadLine();
                switch (operationSelection)
                {
                    case "1":
                    case "addition":
                        // TODO: Write Addition Method
                        number2 = GetUserNumber();
                        number1 = AddNumbers(number1, number2);
                        Console.WriteLine(number1);
                        break;
                    case "2":
                    case "substration":
                        //TODO: Write Substraction Method
                        break;
                    case "3":
                    case "multiplcation":
                        // TODO: Write Multiplication Method
                        break;
                    case "4":
                    case "division":
                        // TODO: Write Division Method
                        break;
                    case "5":
                    case "percentage":
                        // TODO: Write Percentage Method.
                        break;
                    case "6":
                    case "exit":
                        keepGoing = false;
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Addtion");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
        }

        //public static string GetOperation(string operationSelection)
        //{
           
        //}

        public static decimal GetUserNumber()
        {
            return decimal.Parse(Console.ReadLine());
        }

        public static decimal AddNumbers(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

    }
}