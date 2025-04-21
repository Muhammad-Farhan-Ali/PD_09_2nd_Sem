using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class SimpleInterestClass:Interest
    {
        public override double TrueBank(double amount, double rate)
        {
            interest = amount + (amount * rate / 100) + 1000;
            return interest;
        }
    }
}
