using System;
using System.Collections.Generic;
namespace Assignment_01_delegates
{
    internal class Program
    {
        // Interface
        public interface IPaymentMethod
        {
            void Pay(decimal amount);
        }

        public class CreaditCardPayment : IPaymentMethod
        {
            public void Pay(decimal amount)
            {
                Console.WriteLine($"[Credit Card] and amount is {amount}.");
            }
        }
        
        public class PaypalPayment : IPaymentMethod
        {
            public void Pay(decimal amount)
            {
                Console.WriteLine($"[Paypal] and amount is {amount}.");
            }
        }
              
        public class CashPayment : IPaymentMethod
        {
            public void Pay(decimal amount)
            {
                Console.WriteLine($"[Cash] and amount is {amount}.");
            }
        }
        
        public class PaymentProcessor
        {
            private readonly Dictionary<string, IPaymentMethod> _paymentMethods;
            public PaymentProcessor()
            {
                _paymentMethods = new Dictionary<string, IPaymentMethod>();
            }
            public void RegisterPaymentMethod(string methodName, IPaymentMethod method)
            {
                _paymentMethods[methodName] = method;
            }
            public void ProcessPayment(string methodname, decimal amount)
            {
                if (_paymentMethods.ContainsKey(methodname))
                {
                    Console.WriteLine("Loading...");
                    _paymentMethods[methodname].Pay(amount);
                    Console.WriteLine("Done ");
                }
                else
                {
                    Console.WriteLine("payment method is not avaliable.");
                }
            }
        }

        static void Main(string[] args)
        {
            var processor = new PaymentProcessor();
            processor.RegisterPaymentMethod("paypal", new PaypalPayment());

            decimal orderAmount = 450.00m;
            string selectedMethod = "paypal";

            processor.ProcessPayment(selectedMethod, orderAmount);

        }
    }
}
