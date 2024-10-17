using DesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class RemoteWorkScheduleManagement : IScheduleManagement
    {
        public void GenerateReport()
        => Console.WriteLine("Generating Remote Work Report...");
            

        public void CalculateOverTime()
        => Console.WriteLine("Calculating Remote Work Over Time...");

        public void Accept(IScheduleManagementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
