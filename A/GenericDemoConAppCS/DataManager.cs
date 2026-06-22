using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoConAppCS
{
    internal class DataManager<DType>
    {
        private List<DType> list;
        public DataManager()
        {
                list = new List<DType>();
        }
        public void Add(DType item)
        {
            list.Add(item);
        }
        public void Display()
        {
            foreach (DType item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void Remove(DType item)
        {
            list.Remove(item);
        }
        public void Clear()
        {
            list.Clear();
        }
    }
}
