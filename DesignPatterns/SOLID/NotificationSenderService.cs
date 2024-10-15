using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    internal class NotificationSenderService
    {
        public void SendNotification(Order order)
        {
            Console.WriteLine($"Sending notification for order: {order.GetData()}");
        }
    }
}
