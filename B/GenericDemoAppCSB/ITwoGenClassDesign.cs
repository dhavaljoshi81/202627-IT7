using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoAppCSB
{
    internal class TwoGenClassDesign<X, Y> : IGenDataManager<Y>
    {
        private X data;
        public X datavalue
        {
            get
            {
                return data;
            }
        }

        public void Add(Y item)
        {
            throw new NotImplementedException();
        }

        public void Dispaly()
        {
            throw new NotImplementedException();
        }

        public Y Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(Y item)
        {
            throw new NotImplementedException();
        }

        public void TestMethod(Y data)
        {
            throw new NotImplementedException();
        }
    }
}
