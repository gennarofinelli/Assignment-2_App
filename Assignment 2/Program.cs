using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an account number: ");
            string accNum = Console.ReadLine();
            Console.WriteLine("Please enter an account balance: ");
            decimal accBal = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your last name: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Please enter your first name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Please enter interest rate: ");
            decimal interestRate = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter transaction fee: ");
            decimal transactionFee = Decimal.Parse(Console.ReadLine());

            SavingsAccount s = new SavingsAccount(accNum, accBal, lName, fName, interestRate);
            s.DisplayAccount();

            decimal interest = s.calculateInterest();
            s.Credit(interest);
            s.DisplayAccount();

            CheckingAccount c = new CheckingAccount(accNum, accBal, lName, fName, transactionFee);
            c.DisplayAccount();

            c.Credit(50);
            c.DisplayAccount();

            c.Debit(100);
            c.DisplayAccount();
        }
    }
}
