using DesignPatterns.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class ManageLeaveRequestsVisitor : IScheduleManagementVisitor
    {
        public void Visit(DayShiftScheduleManagement dayScheduleManagement)
        {
            Console.WriteLine("Managing Day Shift Leave Requests...");
        }

        public void Visit(NightShiftScheduleManagement nightScheduleManagement)
        {
            Console.WriteLine("Managing Night Shift Leave Requests...");
        }

        public void Visit(RemoteWorkScheduleManagement remoteWorkScheduleManagement)
        {
            Console.WriteLine("Managing Remote Work Leave Requests...");
        }
    }
}
