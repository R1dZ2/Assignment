using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class BankAccount
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Credit(double amount)
        {
            Balance += amount;
        }

        public bool Debit(double amount)
        {
            bool amountPresent = false;
            if (amount <= Balance)
            {
                Balance -= amount;
                amountPresent = true;
            }
            return amountPresent;
        }
    }
}
