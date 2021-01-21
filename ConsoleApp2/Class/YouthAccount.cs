using System;
using System.Collections.Generic;
using System.Text;

namespace BankAutomaat.Class
{
    public class YouthAccount:Account 
    {
        public override void RudeLettersString()
        {
            Console.WriteLine("Tell Daddy you are overdrawn");
        }

        public override bool WithDrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                RudeLettersString();
            }
            else
            {
                GetBalance();

            }

            return base.WithDrawFunds(amount);
        }
    }
}
