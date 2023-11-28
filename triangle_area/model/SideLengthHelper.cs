using System;

namespace TriangleAreaCalculator
{
    public class SideLengthHelper
    {
        public static double GetSideLength(string sideName)
        {
            double sideLength;
            bool isValidLength;

            do
            {
                Console.Write($"Enter the length of {sideName}: ");
                isValidLength = double.TryParse(Console.ReadLine(), out sideLength);

                if (!isValidLength || sideLength <= 0)
                {
                    Console.WriteLine("Please enter a valid positive number for the side length.");
                }
            } while (!isValidLength || sideLength <= 0);

            return sideLength;
        }

        public static double GetHeight()
        {
            double height;
            bool isValidHeight;

            do
            {
                Console.Write("Enter the height: ");
                isValidHeight = double.TryParse(Console.ReadLine(), out height);

                if (!isValidHeight || height <= 0)
                {
                    Console.WriteLine("Please enter a valid positive number for the height.");
                }
            } while (!isValidHeight || height <= 0);

            return height;
        }
    }
}
