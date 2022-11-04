using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance_Example_2_Srk
{
    public class Intrest:Bank
    {
        string? AccountType;
        public void CalculateIntrest()
        {
            AccountType = accountType;
            if(AccountType == "Savings")
            {
                Console.WriteLine("Your intrest rate will be 0.2 based on your account type");
            }
            else
            {
                Console.WriteLine("Your intrest rate will be 0.5 based on your account type");
            }
        }
    }
}
