using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public delegate void GetBonus(double amount);

    class Employee
    {
        BankAccount account = new BankAccount();

        public BankAccount Account
        {
            get { return account; }
            set { account = value; }
        }

        private int numberOfShares;

        public int NumberOfShares
        {
            get { return numberOfShares; }
            set { numberOfShares = value; }
        }

        private double pensionFundBalance;

        public double PensionFundBlance
        {
            get { return pensionFundBalance; }
            set { pensionFundBalance = value; }
        }

        public void SetBankAccountCredit(double amount)
        {
            Account.Credit(amount);
        }

        public void SetPensionFundCredit(double amount)
        {
            PensionFundBlance += amount;
        }

        public void SetNumberOfShares(double amount)
        {
            NumberOfShares = Convert.ToInt32(amount / 100);
        }

        public void GiveBonus(int bonusOption, double amount)
        {
            GetBonus getBonus;
            switch (bonusOption)
            {
                case 1:
                    getBonus = new GetBonus(SetBankAccountCredit);
                    break;

                case 2:
                    getBonus = new GetBonus(SetPensionFundCredit);
                    break;

                case 3:
                    getBonus = new GetBonus(SetNumberOfShares);
                    break;

                default:
                    getBonus = new GetBonus(SetBankAccountCredit);
                    break;
            }
            getBonus(amount);
        }

    }
}
