using System;
using System.Collections.Generic;
namespace Assignment_01_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckoutService payWithPaypal = new CheckoutService(PaymentProcessors.paypal);
            payWithPaypal.payment(500.00m);

            payWithPaypal.changeMethod(PaymentProcessors.cash);
            payWithPaypal.payment(100.50m);
        }
    }
}
