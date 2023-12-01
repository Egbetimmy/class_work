using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_interest.Model
{
    public class CompoundInterestCalculator
    {
        public decimal CalculateCompoundInterest(decimal principal, double rate, short time, int n)
        {
            decimal amount;

            decimal expot = time / (decimal)n;
            double rat = rate / n;

            amount = principal * (decimal)Math.Pow(1 + rat, (double)(expot));

            return amount;
        }
    }
}
