
using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class GoldPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(double price)
        {
            Console.WriteLine("Processing gold pricing strategy.");
            return price * 0.8;
        }
    }
}
