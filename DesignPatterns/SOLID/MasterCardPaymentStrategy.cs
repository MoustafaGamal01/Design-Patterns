﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    internal class MasterCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Proccessing MasterCard Payment...");
        }
    }
}
