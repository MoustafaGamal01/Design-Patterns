using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator.Interfaces
{
    public interface IIterableCollection
    {
        IEmployeeHierarchyIterator CreateEmployeeDirectReportIterator();
        IEmployeeHierarchyIterator CreateEmployeeCoWorkerIterator();
        IEmployeeHierarchyIterator CreateEmployeeSubOrdinatesIterator();
    }
}
