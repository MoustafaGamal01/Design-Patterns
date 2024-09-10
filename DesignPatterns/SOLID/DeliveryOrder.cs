using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    internal class DeliveryOrder : Order, IShippingCostCalculator
    {
        // For Liskov Substitution Principle
        // and now the derived class can be used in place of the base class
        public double CalculateShippingCost(Order order)
        {
            return Total + SHIPPING_COST;
        }
    }
}
