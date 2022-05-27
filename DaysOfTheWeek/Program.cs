using System;

namespace DaysOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DAYS OF WEEK";
            while (true)
            {
                try
                {
                    Console.Write("Input # day: ");
                    int userInputDay = Convert.ToInt32(Console.ReadLine());
                    if (userInputDay >= 1 && userInputDay <= 7)
                    {
                        DayOfWeek(userInputDay);
                    }
                    else
                    {
                        Console.WriteLine("Add day from 1 to 7");
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Not Correct Input");
                }
            }

            static void DayOfWeek(int userInputDay)
            {
                switch (userInputDay)
                {
                    case 1:
                        Console.WriteLine("Mondey");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}