using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class RegularPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(double price)
        {
            Console.WriteLine("Processing regular pricing strategy.");
            return price;
        }
    }
}
