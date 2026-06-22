using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoConAppCS
{
    internal class TestDataManager : IGenClassDesigner<int>
    {
        private List<int> items = new List<int>();
        public TestDataManager() { }
        public void Add(int item)
        {
            items.Add(item);
            
        }

        public void Display()
        {
            foreach (int item in items)
            {
                Console.WriteLine(item);
            }
            
        }

        public void Remove(int item)
        {
            items.Remove(item);
            
        }
    }
}
