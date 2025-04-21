using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount cust1 = new BankAccount(5000);
            BankAccount cust2 = new BankAccount(5000, "Prime");

            cust1.interest=Interest.TrueBank(cust1.getAmount(),10);
            cust2.interest=Interest.TrueBank(cust2.getAmount(),10,cust2.getHolderType());

            Console.WriteLine($"Normal interest for holder: {cust1.interest}");
            Console.WriteLine($"Prime interest for holder: {cust2.interest}");

            Console.ReadKey();
        }
    }
}
