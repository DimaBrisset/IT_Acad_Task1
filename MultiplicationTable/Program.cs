using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Multiplication";

            while (true)
            {
                try
                {
                    double userInputNumber = UserInput();
                    Calculated(userInputNumber);
                }
                catch (Exception)
                {
                    Console.WriteLine("Not Correct Input");
                }
            }
        }

        static double UserInput()
        {
            Console.Write("Start Number: ");
            double startNumber = Convert.ToDouble(Console.ReadLine());
            return startNumber;
        }

        static void Calculated(double number)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{number}*{i}={number * i}");
            }
            Console.WriteLine();
        }
    }
}