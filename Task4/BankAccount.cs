using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class BankAccount
    {
        double amount;
        public Interest interest_Inst;

        public BankAccount(double amount)
        {
            this.amount = amount;
        }
        public double getAmount()
        {
            return amount;
        }
        public void setAmount(double amount)
        {
            this.amount=amount;
        }
        public double getNormalInterest(double rate)
        {
            interest_Inst = new Interest();
            interest_Inst.TrueBank(amount,rate);
            return interest_Inst.getInterestVal();
        }
        public double getSimpleInterest(double rate)
        {
            interest_Inst = new SimpleInterestClass();
            interest_Inst.TrueBank(amount, rate);
            return interest_Inst.getInterestVal();
        }
        public double getFixedInterest(double rate)
        {
            interest_Inst = new FixedInterestClass();
            interest_Inst.TrueBank(amount, rate);
            return interest_Inst.getInterestVal();
        }
    }
}
