using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class Employee
    {
        private int Id;
        private string Name;

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        
    }
}
