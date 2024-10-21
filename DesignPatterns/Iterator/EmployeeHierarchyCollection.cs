using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator.Interfaces;

namespace DesignPatterns.Iterator
{
    public class EmployeeHierarchyCollection : IIterableCollection
    {
        private List<Employee> employees = new List<Employee>();

        private string employeeId;
        private int currDirectReportPosition = 0;
        private int currCoWorkerReportPosition = 0;
        private int currSubOrdinatesPosition = 0;

        public EmployeeHierarchyCollection(string employeeId)
        {
            this.employees = new List<Employee>{
                new Employee(123, "Ahmed"),
                new Employee(345, "Ali"),
            };
            this.employeeId = employeeId;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public IEmployeeHierarchyIterator CreateEmployeeDirectReportIterator()
        {
            return new EmployeeDirectReportIterator(this);
        }

        public IEmployeeHierarchyIterator CreateEmployeeCoWorkerIterator()
        {
            return new EmployeeCoWorkerIterator(this);
        }

        public IEmployeeHierarchyIterator CreateEmployeeSubOrdinatesIterator()
        {
            return new EmployeeSubOrdinatesIterator(this);
        }
    }
}
