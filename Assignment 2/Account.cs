using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Account
    {
        private String accNum;
        private Decimal accBal;
        private String lastName;
        private String firstName;

        public Account(string accNum, decimal accBal, string lastName, string firstName)
        {
            AccNum = accNum;
            AccBal = accBal;
            LastName = lastName;
            FirstName = firstName;
        }
        public String AccNum
        {
            get
            {
                return accNum;
            }
            set
            {
                accNum = value;
            }
        }
        public Decimal AccBal
        {
            get
            {
                return accBal;
            }
            set
            {
                if(accBal < 0m) 
                {
                    Console.WriteLine("Account initial balance amount should be a positive value.");
                }
                else
                {
                    accBal = value;
                }
            }
        }
        public String LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public String FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public virtual void Credit(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Cannot add negatives to account balance.");
            }
            else
            {
                accBal = accBal + value;
            }
        }
        public virtual bool Debit(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else
            {
                accBal = accBal - value;
                return true;
            }
        }

        public virtual void DisplayAccount()
        {
            drawLine();
            Console.WriteLine($"| {"Account",25} {"|",20}");
            drawLine();

            Console.WriteLine($"| {"Account Number", -15} | {AccNum, 26} |");
            Console.WriteLine($"| {"Account Balance", -15} | {"$" + AccBal, 26} |");
            Console.WriteLine($"| {"Last Name", -15} | {LastName, -26} |");
            Console.WriteLine($"| {"First Name",-15} | {FirstName,-26} |");
            drawLine();
        }

        public static void drawLine()
        {
            Console.Write("|");
            for (int i = 0; i < 46; i++)
                Console.Write("-");
            Console.WriteLine("|");
        }
    }
}
