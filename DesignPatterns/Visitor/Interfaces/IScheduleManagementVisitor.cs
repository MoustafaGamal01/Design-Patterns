using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Interfaces
{
    public interface IScheduleManagementVisitor
    {
        void Visit(DayShiftScheduleManagement dayScheduleManagement);
        void Visit(NightShiftScheduleManagement nightScheduleManagement);
        void Visit(RemoteWorkScheduleManagement remoteWorkScheduleManagement);
    }
}
