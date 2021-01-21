using System;
using System.Collections.Generic;
using System.Text;

namespace BankAutomaat.Class
{
    public class CustomerAccount:Account
    {
        public override bool WithDrawFunds(decimal amount)
        {
            if (Balance - amount >= 0)
            {
                Balance = Balance - amount;
                return true;
            }
            return false;
        }
    }
}
