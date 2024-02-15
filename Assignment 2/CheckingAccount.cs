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

        
    }
}
