using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoConAppCS
{
    internal interface IStudent : IGenClassDesigner<Student>
    {
    }

    class StudentManager : IStudent
    {
        public void Add(Student item)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Remove(Student item)
        {
            throw new NotImplementedException();
        }
    }
}
