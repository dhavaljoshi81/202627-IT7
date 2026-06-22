using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoAppCSB
{
    internal interface IGenDataManager<Y> : IClassDesign<Y>
    {
        void TestMethod(Y data);
    }

    class DemoClass : IGenDataManager<string>
    {
        public void Add(string item)
        {
            throw new NotImplementedException();
        }

        public void Dispaly()
        {
            throw new NotImplementedException();
        }

        public string Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(string item)
        {
            throw new NotImplementedException();
        }

        public void TestMethod(string data)
        {
            throw new NotImplementedException();
        }
    }

    class GenDemoTest<MyType> : IGenDataManager<MyType>
    {
        public void Add(MyType item)
        {
            throw new NotImplementedException();
        }

        public void Dispaly()
        {
            throw new NotImplementedException();
        }

        public MyType Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(MyType item)
        {
            throw new NotImplementedException();
        }

        public void TestMethod(MyType data)
        {
            throw new NotImplementedException();
        }
    }
}
