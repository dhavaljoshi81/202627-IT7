using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoConAppCS
{
    internal interface IGenClassDesigner<T>
    {
        void Add(T item);
        void Remove(T item);
        void Display();
    }
}
