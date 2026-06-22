using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoConAppCS
{
    internal class Student
    {
        public int RNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "RNo:" + RNo + " Name:" + Name + " Age:" + Age;
        }
    }
}
