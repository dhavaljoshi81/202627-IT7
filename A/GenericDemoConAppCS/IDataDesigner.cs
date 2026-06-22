using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoConAppCS
{
    internal interface IDataDesigner<T> : IGenClassDesigner<T>
    {
        void ShowDatawithNewItem(T item);
    }

    class MyClass : IDataDesigner<int>
    {
        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void ShowDatawithNewItem(int item)
        {
            throw new NotImplementedException();
        }
    }

}
