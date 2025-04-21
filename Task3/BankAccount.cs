using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class BankAccount
    {
        double amount;
        string holdertype;
        public double interest;

        public BankAccount(double amount, string holdertype)
        {
            this.amount = amount;
            this.holdertype = holdertype;
        }
        public BankAccount(double amount)
        {
            this.amount = amount;
        }
        public string getHolderType()
        {
            return holdertype;
        }
        public void setHoldertype(string holdertype)
        {
            this.holdertype=holdertype;
        }
        public double getAmount()
        {
            return amount;
        }
        public void setAmount(double amount)
        {
            this.amount=amount;
        }
    }
}
