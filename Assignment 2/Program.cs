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
            Account ac = new Account("7431592", 284.97m, "Dumitrescu Tiving", "Craig Justin Vinoya");

            ac.DisplayAccount();

            Console.WriteLine();

            SavingsAccount sAC = new SavingsAccount("8753124", 537.68m, "Dumitrescu Tiving", "Craig Justin Vinoya", 0.0413m);

            sAC.DisplayAccount();
        }
    }
}
