using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class FixedInterestClass:Interest
    {
        public override double TrueBank(double amount, double rate)
        {
            interest = amount + (amount * rate / 100) + 1500;
            return interest;
        }
    }
}
