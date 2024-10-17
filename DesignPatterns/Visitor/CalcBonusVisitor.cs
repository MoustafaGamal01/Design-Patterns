using DesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class CalcBonusVisitor : IScheduleManagementVisitor
    {
        public void Visit(DayShiftScheduleManagement dayScheduleManagement)
            => Console.WriteLine("Calculating Day Shift Bonus...");

        public void Visit(NightShiftScheduleManagement nightScheduleManagement)
            => Console.WriteLine("Calculating Night Shift Bonus...");

        public void Visit(RemoteWorkScheduleManagement remoteWorkScheduleManagement)
            => Console.WriteLine("Calculating Remote Work Bonus...");
    }
}
