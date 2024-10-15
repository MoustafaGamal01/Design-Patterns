using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class VisaPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double price)
        {
            Console.WriteLine($"Visa payment processed successfully - {price}");
            Console.WriteLine("Calculate fees for Visa payment... ");
        }
    }
}
