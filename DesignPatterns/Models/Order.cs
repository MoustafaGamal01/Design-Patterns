using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }

        public Order(int id, string description, double total)
        {
            Id = id;
            Description = description;
            Total = total;
        }

        public string GetData()
        {
            return $"Order Id: {Id}, Description: {Description}, Total: {Total}";
        }
        public double GetTotalPrice()
        {
            return Total;
        }
    }
}
