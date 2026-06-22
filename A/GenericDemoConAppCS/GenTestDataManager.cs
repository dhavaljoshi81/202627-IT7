
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoConAppCS
{
    internal class GenTestDataManager<DType> : IGenClassDesigner<DType>
    {
        private List<DType> data = new List<DType>();   
        public void Add(DType item)
        {
            data.Add(item);
        }

        public void Display()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public void Remove(DType item)
        {
            data.Remove(item);
        }
    }
}
