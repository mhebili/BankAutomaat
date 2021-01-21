using System;
using System.Collections.Generic;
using System.Text;

namespace BankAutomaat.Interface
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithDrawFunds(decimal amount);
        decimal GetBalance();
        void RudeLettersString();
    }
}
