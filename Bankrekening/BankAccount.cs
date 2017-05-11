using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    public class BankAccount
    {
        static public double balance;

        public string Name { get; set; }
        public string Address { get; set; }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(balance < amount)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                balance -= amount;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            Console.WriteLine(Balance);
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }

        }

    }
}
