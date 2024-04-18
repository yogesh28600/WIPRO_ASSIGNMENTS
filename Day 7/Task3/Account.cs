using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Account
    {
        private double balance;

        public double deposit(double amount)
        {
            balance += amount;
            return balance;
        }
        public double withdraw(double amount)
        {
            if(amount > balance)
            {
                throw new Exception("Insufficient balance");
            }
            balance -= amount;
            return balance;
        }
        public double checkBalance()
        {
            return balance;
        }
    }
}
