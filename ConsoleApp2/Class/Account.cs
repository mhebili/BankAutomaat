using BankAutomaat.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAutomaat.Class
{
    public class Account : IAccount
    {
        public decimal Balance;

        public decimal GetBalance()
        {
            return Balance;
        }

        public void PayInFunds(decimal amount)
        {
            Balance = Balance + amount;
        }

        public virtual void RudeLettersString()
        {
            Console.WriteLine("Balance: " + Balance);
        }

        public virtual bool WithDrawFunds(decimal amount)
        {
            Balance = Balance - amount;
            return true;
        }
    }
}
