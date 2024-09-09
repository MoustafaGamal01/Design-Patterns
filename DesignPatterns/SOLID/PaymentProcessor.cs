using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    internal class PaymentProcessor
    {
        private readonly IPaymentStrategy strategy;

        public PaymentProcessor(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ProcessOrderPayment(Order order)
        { 
            Console.WriteLine($"Processing payment for order: {order.GetData()}");
            Console.WriteLine($"Issuing payment for amount: {order.GetTotalPrice()}");

            // if(payment.GetType == "MasterCard")
            // else if(payment.GetType == "Visa")
            // else ...

            // To achieve open closed principle, we can use strategy pattern
            // so we will make an interface and a concrete class for each payement method 
            // implementing this interface and in case we need to add some other method like "Paypal"
            // we will just add a new class implementing the interface (IPaymentStrategy) and pass it to the PaymentProcessor
            
            strategy.ProcessPayment(order.GetTotalPrice());
        }
    }
}
