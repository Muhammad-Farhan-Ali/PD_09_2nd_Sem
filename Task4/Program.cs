using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount cust1 = new BankAccount(5000);
            BankAccount cust2 = new BankAccount(5000);

            double rate=10.0F;

            Console.WriteLine($"Normal interest for holder: {cust1.getNormalInterest(rate)}");
            Console.WriteLine($"Simple interest for holder: {cust2.getSimpleInterest(rate)}");
            Console.WriteLine($"Fixed interest for holder: {cust2.getFixedInterest(rate)}");

            Console.ReadKey();
        }
    }
}
