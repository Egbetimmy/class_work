using System;

namespace Compound_interest.Model
{
    public class CompoundInterest
    {
        private readonly CompoundInterestCalculator calculator;

        public CompoundInterest()
        {
            calculator = new CompoundInterestCalculator();
        }

        public (decimal interest, decimal compoundInterest) CalculateInterest(decimal principal, double rate, short time, int n)
        {
            decimal compoundInterest = calculator.CalculateCompoundInterest(principal, rate, time, n);
            decimal interest = compoundInterest - principal;
            return (interest, compoundInterest);
        }
    }
}
