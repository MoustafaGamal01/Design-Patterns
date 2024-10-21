using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Interfaces;

namespace DesignPatterns.Iterator
{
    public class EmployeeDirectReportIterator : IEmployeeHierarchyIterator
    {
        private EmployeeHierarchyCollection employeeHierarchyCollection;
        private int currDirectReportPosition = 0;

        public EmployeeDirectReportIterator(EmployeeHierarchyCollection employeeHierarchyCollection)
        {
            this.employeeHierarchyCollection = employeeHierarchyCollection;
        }

        public bool hasNext()
        {
            return employeeHierarchyCollection.GetEmployees().Count > currDirectReportPosition;
        }

        public Employee getNextEmployee()
        {
            Console.WriteLine("Iterating through Direct Report a graph DFS/BFS");
            if (!hasNext())
            {
                return null;
            }
            return employeeHierarchyCollection.GetEmployees()[currDirectReportPosition++];
        }
    }
}
