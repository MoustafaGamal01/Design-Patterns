using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID
{
    internal class OrderManagement
    {
        public void ManageOrderOrder(Order order)
        {
            Console.WriteLine($"Managing order: {order.GetData()}");
        }
    }
}
