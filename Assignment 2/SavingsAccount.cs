using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class SavingsAccount : Account
    {
        private Decimal interestRate;

        public SavingsAccount(string accNum, decimal accBal, string lastName, string firstName, decimal interestRate) 
            : base(accNum, accBal, lastName, firstName)
        {
            if (interestRate < 0m)
            {
                Console.WriteLine("Interest Rate should be a positive value.");
                InterestRate = 0.05m;
            }
            else
            {
                InterestRate = interestRate;
            }
        }

        public Decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }

        public decimal calculateInterest()
        {
            return InterestRate * AccBal;
        }

        public override void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"Savings Account",25} {"|",20}");
            drawLine();

            Console.WriteLine($"| {"Account Number",-15} | {AccNum,26} |");
            Console.WriteLine($"| {"Account Balance",-15} | {"$" + AccBal.ToString("N2"),26} |");
            Console.WriteLine($"| {"Last Name",-15} | {LastName,-26} |");
            Console.WriteLine($"| {"First Name",-15} | {FirstName,-26} |");
            Console.WriteLine($"| {"Interest Rate", -15} | {"$" + (InterestRate*100).ToString("N2"), 26} |");
            Console.WriteLine($"| {"Interest Amount",-15} | {"$" + calculateInterest().ToString("N2"),26} |");
            drawLine();
        }
    }
}
