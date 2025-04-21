using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Interest
    {
        protected double interest;
        public virtual double TrueBank(double amount,double rate) 
        {
            interest = amount + (amount * rate / 100);
            return interest; 
        }

        public double getInterestVal()
        {
            return interest;
        }
    }
}
