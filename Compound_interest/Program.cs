using Compound_interest.Model;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        double interestRate;
        decimal principalAmount;
        short duration;
        int compoundFrequency;

        Console.WriteLine("Enter interest rate: ");
        interestRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter principal amount: ");
        principalAmount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter duration (in years): ");
        duration = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter number of times interest is compounded per year: ");
        compoundFrequency = Convert.ToInt32(Console.ReadLine());

        CompoundInterest compoundInterest = new CompoundInterest();

        // Calculate accrued interest and compound interest together in a tuple
        (decimal accruedInterest, decimal totalAmount) = compoundInterest.CalculateInterest(
            principalAmount, interestRate, duration, compoundFrequency);

        Console.WriteLine("Accrued interest after calculation: " + accruedInterest);
        Console.WriteLine("Total Amount after calculation: " + totalAmount);
    }
}
