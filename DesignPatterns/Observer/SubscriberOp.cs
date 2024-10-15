using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class SubscriberOp : ISubscriber
    {
        public string name { get; set; }

        public SubscriberOp(string name)
        {
            this.name = name;
        }

        public void Notify(string message)
        {
            Console.WriteLine(message+$"for {name}");
        }
    }
}
