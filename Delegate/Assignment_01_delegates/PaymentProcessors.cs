using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_delegates
{
    class PaymentProcessors
    {

        public static void paypal(decimal amount)
        {
            Console.WriteLine($"you pay with paypal your pile is {amount}");
        }
        public static void visa(decimal amount)
        {
            Console.WriteLine($"you pay with visa your pile is {amount}");
        }
        public static void cash(decimal amount)
        {
            Console.WriteLine($"you pay with cash your pile is {amount}");
        }

    }
}
