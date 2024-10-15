using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Product
    {
        private string name { get;  }
        private double price { get;  }
        private readonly IPricingStrategy pricingStrategy;
        
        public Product(string name, double price, IPricingStrategy pricingStrategy)
        {
            this.name = name;
            this.price = price;
            this.pricingStrategy = pricingStrategy;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public double CalculatePrice()
        {
            return pricingStrategy.CalculatePrice(price);
        }
    }
}
