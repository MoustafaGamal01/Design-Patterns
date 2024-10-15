using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class MastercardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double price)
        {
            Console.WriteLine($"MasterCard payment processed successfully - {price}");
            Console.WriteLine("Calculate fees for MasterCard payment...");
        }
    }
}
