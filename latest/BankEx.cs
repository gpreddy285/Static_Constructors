using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latest
{
    public class BankEx
    {
        private double balance;
        private int pin;
        public void Deposit(double amount)
        {
            balance = balance + amount;
        }
        public void Withdraw(int pin, double amount)
        {
            if (amount < balance && pin == 1234)
            {
                balance = balance - amount;
            }
        }
       public double totalbalance()
        {
            return balance;
        }
    }

}

