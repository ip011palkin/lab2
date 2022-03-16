using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // RomanNumber nr1 = new RomanNumber(0); 
                RomanNumber number1 = new RomanNumber(24);
                RomanNumber number2 = new RomanNumber(16);
                RomanNumber number3 = new RomanNumber(14);
                // RomanNumber nr3 = new RomanNumber(92);
                RomanNumber number4 = new RomanNumber(3);
                RomanNumber number5 = new RomanNumber(8);
                Console.WriteLine($"addition: {number1.ToString()} + {number2.ToString()} = {RomanNumber.Add(number1, number2).ToString()}");
                Console.WriteLine($"subtraction: {number1.ToString()} - {number3.ToString()} = {RomanNumber.Sub(number1, number3).ToString()}");
                Console.WriteLine($"multiplication: {number1.ToString()} * {number4.ToString()} = {RomanNumber.Mul(number1, number4).ToString()}");
                Console.WriteLine($"division: {number1.ToString()} / {number5.ToString()} = {RomanNumber.Div(number1, number5).ToString()}");
                RomanNumber[] array = { number1, number2, number3, number4, number5 };
                Array.Sort(array);
                Console.WriteLine("sort result");
                foreach (var i in array)
                {
                    Console.WriteLine(i.ToString());
                }

            }
            catch (RomanNumberException exception)
            {
                Console.WriteLine($"error: {exception.Message}");
            }

        }
    }
}