using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor.Interfaces
{
    public interface IScheduleManagement
    {
        void GenerateReport();
        void CalculateOverTime();
        void Accept(IScheduleManagementVisitor visitor);
    }
}
