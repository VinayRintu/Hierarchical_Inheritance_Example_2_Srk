// See https://aka.ms/new-console-template for more information
using Hierarchical_Inheritance_Example_2_Srk;

Console.WriteLine("Hello, World!");


Intrest objIntrest = new Intrest();

objIntrest.accountHolderName = "Vinay";
Console.WriteLine("Account Holder Name  :"+objIntrest.accountHolderName);

objIntrest.accountNumber = 123123123;
Console.WriteLine("Account Number  :"+objIntrest.accountNumber);

objIntrest.accountType = "Savings";
Console.WriteLine("Account Type  :"+objIntrest.accountType);
Console.WriteLine("\n");

objIntrest.CalculateIntrest();
Console.WriteLine("\n");

Amount objAmount=new Amount();
objAmount.accountBalance = 25000;
Console.WriteLine("\n");
Console.WriteLine("Your Account Balance is  :"+ objAmount.accountBalance);
objAmount.CalculateAmount();