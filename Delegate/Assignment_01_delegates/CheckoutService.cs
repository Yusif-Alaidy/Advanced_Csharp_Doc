using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_delegates
{
    public delegate void PaymentMethod(decimal amount); 
    class CheckoutService
    {
        private PaymentMethod paymentMethod;
        public CheckoutService(PaymentMethod _paymentMethod)
        {
            paymentMethod = _paymentMethod;
        }
        public void changeMethod(PaymentMethod _paymentMethod)
        {
            paymentMethod = _paymentMethod;
        }
        public void payment(decimal amount)
        {
            Console.WriteLine("\npayment process is loading...");
            paymentMethod(amount);
            Console.WriteLine("payment process is done.\n");
        }
    }
}
