using System;

namespace TriangleAreaCalculator
{
    public class TriangleCalculatorHM
    {
        public static void CalculateUsingThreeSides()
        {
            Console.WriteLine("Calculate area using three sides (Heron's formula):");

            double side1 = SideLengthHelper.GetSideLength("side 1");
            double side2 = SideLengthHelper.GetSideLength("side 2");
            double side3 = SideLengthHelper.GetSideLength("side 3");

            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            Console.WriteLine($"Area of the triangle using Heron's formula = {area}");
        }
    }
}
