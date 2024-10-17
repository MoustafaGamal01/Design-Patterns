using DesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class DayShiftScheduleManagement :IScheduleManagement
    {
        public void GenerateReport()
       => Console.WriteLine("Generating Day Shift Report...");


        public void CalculateOverTime()
        => Console.WriteLine("Calculating Day Shift Over Time...");

        public void Accept(IScheduleManagementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
