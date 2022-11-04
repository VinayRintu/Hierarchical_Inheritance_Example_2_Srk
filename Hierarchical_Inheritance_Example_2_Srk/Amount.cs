using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance_Example_2_Srk
{
    public class Amount: Bank
    {
       public double accountBalance;
        
        public void CalculateAmount()
        {
            Console.WriteLine("Enter Transaction Type, if Credit Enter c or C,  if Debit Enter d or D ");
            string transactionType=Console.ReadLine();

            if (transactionType == "c" || transactionType == "C")
            {
                Console.WriteLine("Enter Amount to Credit");
                int AmountOfCredit=int.Parse(Console.ReadLine());
                accountBalance=accountBalance+AmountOfCredit;
                Console.WriteLine("Current Balance is :  "+accountBalance);
            }
            else
            {
                Console.WriteLine("Enter Amount to Debit");
                int AmountOfDebit = int.Parse(Console.ReadLine());
                if (AmountOfDebit > accountBalance)
                {
                    Console.WriteLine("InSufficient Balance");
                }
                else
                {
                    accountBalance = accountBalance - AmountOfDebit;
                    Console.WriteLine("Current Balance is :  " + accountBalance);
                }
            }
            
        }

    }
}
