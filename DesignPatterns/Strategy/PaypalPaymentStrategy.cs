using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class PaypalPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double price)
        {
            Console.WriteLine($"PayPal payment processed successfully - {price}");
        }
    }
}
