using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoAppCSB
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Name:" + Name + " Age:" + Age;
        }
    }
}
