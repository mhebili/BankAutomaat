using BankAutomaat.Class;
using System;

namespace BankAutomaat
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerAccount customer = new CustomerAccount();
            customer.PayInFunds(100.00M);

            Console.WriteLine(customer.GetBalance());
            Console.WriteLine(customer.WithDrawFunds(50M));
            Console.WriteLine(customer.GetBalance());

            Console.WriteLine("=========================================");


            YouthAccount YouthAccount = new YouthAccount();
            YouthAccount.PayInFunds(100.00M);

            Console.WriteLine(YouthAccount.GetBalance());
            Console.WriteLine(YouthAccount.WithDrawFunds(9M));
            Console.WriteLine(YouthAccount.GetBalance());

            Console.ReadLine();
        }
    }
}
