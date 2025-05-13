using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_event
{
    class BankAccount
    {
        public event amoutIsLowEvenHandler amountIsLow;
        public delegate void amoutIsLowEvenHandler();

        float amount { get; set; }

        public void withdraw(float money)
        {
            amount -= money;
            if (amount < 30)
            {
                amountIsLow?.Invoke();
            } 
            return;
        }        
        public void Deposit(float money)
        {
            amount += money;
            return;
        }

        public void myCash()
        {
            Console.WriteLine($"your cash is: {amount}");
        }

        

    }
}
