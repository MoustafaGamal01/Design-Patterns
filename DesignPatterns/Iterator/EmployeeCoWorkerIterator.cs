using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Interfaces;

namespace DesignPatterns.Iterator
{
    public class EmployeeCoWorkerIterator: IEmployeeHierarchyIterator
    {
        private EmployeeHierarchyCollection employeeHierarchyCollection;
        private int currCoWorkerReportPosition = 0;

        public EmployeeCoWorkerIterator(EmployeeHierarchyCollection employeeHierarchyCollection)
        {
            this.employeeHierarchyCollection = employeeHierarchyCollection;
        }

        public bool hasNext()
        {
            return employeeHierarchyCollection.GetEmployees().Count > currCoWorkerReportPosition;
        }

        public Employee getNextEmployee()
        {
            Console.WriteLine("Iterating through Co-Worker a graph DFS/BFS");
            if (!hasNext())
            {
                return null;
            }
            return employeeHierarchyCollection.GetEmployees()[currCoWorkerReportPosition++];
        }
    }
}
