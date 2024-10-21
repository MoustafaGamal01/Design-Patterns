using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Interfaces;

namespace DesignPatterns.Iterator
{
    public class EmployeeSubOrdinatesIterator : IEmployeeHierarchyIterator
    {
        private EmployeeHierarchyCollection employeeHierarchyCollection;
        private int currSubOrdinatesPosition = 0;

        public EmployeeSubOrdinatesIterator(EmployeeHierarchyCollection employeeHierarchyCollection)
        {
            this.employeeHierarchyCollection = employeeHierarchyCollection;
        }

        public bool hasNext()
        {
            return employeeHierarchyCollection.GetEmployees().Count > currSubOrdinatesPosition;
        }

        public Employee getNextEmployee()
        {
            Console.WriteLine("Iterating through SubOrdinates a graph DFS/BFS");
            if (!hasNext())
            {
                return null;
            }
            return employeeHierarchyCollection.GetEmployees()[currSubOrdinatesPosition++];
        }
    }
}
