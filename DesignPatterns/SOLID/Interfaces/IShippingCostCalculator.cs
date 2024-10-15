using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.Interfaces
{
    // For Liskov Substitution Principle
    // Instead of making any class that extends order class 
    // get the same CalculateShippingCost method
    // this way we can make sure that the method is implemented
    // in the derived class
    internal interface IShippingCostCalculator
    {
        double CalculateShippingCost(Order order);
    }
}
