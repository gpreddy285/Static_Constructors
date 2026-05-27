using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latest
{
    public class Bank
    {
        private double balance;
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance = balance - amount;
            }
        }
        public double Getbalance()
        {
            {
                return balance;
            }
        }


    }
}
