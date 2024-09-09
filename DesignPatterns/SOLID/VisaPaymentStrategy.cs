﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    internal class VisaPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Proccessing Visa Card Payment...");
        }
    }
}