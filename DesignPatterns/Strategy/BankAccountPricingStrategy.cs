using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Interfaces
{
    public class BankAccountPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(double price)
        {
            Console.WriteLine("Processing Bank Account pricing strategy.");
            return price * 0.5;
        }
    }
}
