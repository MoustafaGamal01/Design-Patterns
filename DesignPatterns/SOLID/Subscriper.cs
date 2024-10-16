﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.SOLID.Interfaces;

namespace DesignPatterns.SOLID
{
    public class Subscriber : ISubscriptionNotificationService
    {
        // Violation of Interface Segregation Principle!
        // so we will implement the methods of the interface that he uses
        // in this class in another Interface
        private string Email;

        public void SubscribeToNewProductsAvailability()
        {
            Console.WriteLine("Subscribing to new products availability...");
        }

        public void SubscribeToSMSNorifications()
        {
            Console.WriteLine("Subscribing to SMS notifications...");
        }
    }
}
