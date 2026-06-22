using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoConAppCS
{
    internal interface ITwoDataManager<OneType, TwoType> : IGenClassDesigner<TwoType>
    {
        void TestMethod(OneType item);
        OneType GetOneTypeItem();
    }
    class TwoTypeClass : ITwoDataManager<int, Student>
    {
        public void Add(Student item)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public int GetOneTypeItem()
        {
            throw new NotImplementedException();
        }

        public void Remove(Student item)
        {
            throw new NotImplementedException();
        }

        public void TestMethod(int item)
        {
            throw new NotImplementedException();
        }
    }

}
