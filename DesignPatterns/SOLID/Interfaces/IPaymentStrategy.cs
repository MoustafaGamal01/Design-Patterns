global using DesignPatterns.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.Interfaces
{
    internal interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }
}
