using DesignPatterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Checkout
    {
        private readonly IPaymentStrategy paymentMethod;

        public Checkout(IPaymentStrategy paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public void ProcessPayment(double amount) 
        {
            paymentMethod.Pay(amount);
        }
    }
}
