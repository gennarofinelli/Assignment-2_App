using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class CheckingAccount : Account
    {
        private decimal transactionFee;

        public CheckingAccount(string accNum, decimal accBal, string lastName, string firstName, decimal fee) 
            : base(accNum, accBal, lastName, firstName)
        {
            if (fee < 0)
            {
                TransactionFee = 1.5m;
                Console.WriteLine("Transaction fee should be a positive value.");
            }
            else
            {
                TransactionFee = fee;
            }
        }

        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                transactionFee = value;
            }
        }

        public override void Credit(decimal value)
        {
            base.Credit(value);
            if(base.Debit((int)TransactionFee)) 
            {
                Console.WriteLine($"Transaction fee of {TransactionFee} deducted from credit.");
            }
        }

        public override bool Debit(decimal value)
        {
            bool success =  base.Debit(value);
            if (success)
            {
                base.Debit((int)TransactionFee);
                Console.WriteLine($"Transaction fee of {TransactionFee} deducted from debit.");
            }

            return success;
        }

        public override void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"Checkings Account",25} {"|",20}");
            drawLine();

            Console.WriteLine($"| {"Account Number",-15} | {AccNum,-26} |");
            Console.WriteLine($"| {"Account Balance",-15} | {"$" + AccBal.ToString("N2"),26} |");
            Console.WriteLine($"| {"Last Name",-15} | {LastName,-26} |");
            Console.WriteLine($"| {"First Name",-15} | {FirstName,-26} |");
            Console.WriteLine($"| {"Transaction Fee",-15} | {"$"+TransactionFee.ToString("N2"),26} |");
            drawLine();
        }
    }
}
