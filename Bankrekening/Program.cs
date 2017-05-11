using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount userBankaccount = new BankAccount();
            Console.WriteLine("What is your name?");
            userBankaccount.Name = Console.ReadLine();
            Console.WriteLine("What is your address?");
            userBankaccount.Address = Console.ReadLine();
            userBankaccount.Balance = 2000;

            bool finished = false;
            while (!finished)
            {

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Deposit money in the account");
                Console.WriteLine("2. Withdraw money from the account");
                Console.WriteLine("3. Show the account's information");
                int keuze = int.Parse(Console.ReadLine());

                switch (keuze)
                {
                    case 0:
                        finished = true;
                        break;
                    case 1:
                        Console.WriteLine("How much money do you want to deposit?");
                        int depositAmount = int.Parse(Console.ReadLine());
                        userBankaccount.Deposit(depositAmount);
                        Console.WriteLine(userBankaccount.Balance);
                        break;
                    case 2:
                        Console.WriteLine("How much money do you want to withdraw?");
                        int withdrawAmount = int.Parse(Console.ReadLine());
                        Console.WriteLine("You will get your cash in just a moment...");
                        userBankaccount.Withdraw(withdrawAmount);
                        break;
                    case 3:
                        userBankaccount.ShowInfo();
                        break;
                }
            }
    }
}
}
