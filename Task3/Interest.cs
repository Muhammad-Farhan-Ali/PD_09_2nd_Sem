using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Interest
    {
        public static double TrueBank(double amount,double rate) 
        {
            return amount + (amount * rate/100); 
        }
        public static double TrueBank(double amount, double rate,string holdertype)
        {
            return amount + (amount * rate/100)+2000;
        }
    }
}
