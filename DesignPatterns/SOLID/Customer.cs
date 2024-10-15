using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.SOLID.Interfaces;

namespace DesignPatterns.SOLID
{
    public class Customer : IUserManager, ISubscriptionNotificationService
    {
        private string Name;
        private string Email;

        public Customer(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SubscribeToNewProductsAvailability()
        {
            Console.WriteLine("Subscribing to new products availability...");
        }

        public void SubscribeToSMSNorifications()
        {
            Console.WriteLine("Subscribing to SMS notifications...");
        }

        public void UpdateToUserProfile(Customer customer)
        {
            Console.WriteLine($"Updating user profile + {customer.GetName()}...");
        }

        public void ChangePassword(Customer customer, string newPassword)
        {
            Console.WriteLine($"Updating User: {customer.GetName()} ...");
        }
    }
}
