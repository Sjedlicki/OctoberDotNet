using System;

namespace Day_7___Try_Catches
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                Console.Write("Enter Number: ");
                int input1 = int.Parse(Console.ReadLine());

                Console.Write("Enter another Number: ");
                int input2 = int.Parse(Console.ReadLine());

                int result = input1 / input2;
                Console.WriteLine(result);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch(ArithmeticException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                throw new Exception("You done really messed up this time fool!");
            }
        }
    }
}