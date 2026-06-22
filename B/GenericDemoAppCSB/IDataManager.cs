using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoAppCSB
{
    internal interface IDataManager : IClassDesign<int>
    {
    }

    class Test : IDataManager
    {
        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Dispaly()
        {
            throw new NotImplementedException();
        }

        public int Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(int item)
        {
            throw new NotImplementedException();
        }
    }
}
