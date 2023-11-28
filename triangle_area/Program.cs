using System;

namespace TriangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Area Calculator");
            Console.WriteLine("------------------------");

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate using three sides (Heron's formula)");
            Console.WriteLine("2. Calculate using base and height");

            int choice;
            bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                     TriangleCalculatorHM.CalculateUsingThreeSides();
                    break;
                case 2:
                    TriangleCalculatorBA.CalculateUsingBaseAndHeight();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select 1 or 2.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
