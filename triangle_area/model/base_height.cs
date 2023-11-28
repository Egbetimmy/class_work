using System;

namespace TriangleAreaCalculator
{
    public class TriangleCalculatorBA
    {
        public static void CalculateUsingBaseAndHeight()
        {
            Console.WriteLine("Calculate area using base and height:");

            double baseLength = SideLengthHelper.GetSideLength("base");
            double height = SideLengthHelper.GetHeight();

            double area = 0.5 * baseLength * height;

            Console.WriteLine($"Area of the triangle using Base * Height = {area}");
        }
    }
}
