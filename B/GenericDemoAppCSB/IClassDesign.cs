using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoAppCSB
{
    internal interface IClassDesign<T>
    {
        void Add(T item);
        void Remove(T item);
        T Get(int index);
        void Dispaly();

    }
    class EmpList : IClassDesign<Employee>
    {
        private List<Employee> employees = new List<Employee>();
        
        public void Add(Employee item)
        {
            employees.Add(item);
        }

        public void Dispaly()
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }

        public Employee Get(int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(Employee item)
        {
            throw new NotImplementedException();
        }
    }

}
