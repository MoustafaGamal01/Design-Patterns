using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    // For Liskov Substitution Principle
    // here we don't need to calculate the shipping cost
    // because the order is picked up
    // so we don't need to implement the IShippingCostCalculator
    // and now the derived class can be used in place of the base class
    internal class PickUpOrder : Order
    {

    }
}
