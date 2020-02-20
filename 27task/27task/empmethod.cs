using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27task
{
    class empmethod
    {
        List<employee> emp = new List<employee>();
        public void add(int eid ,string ename,string designation,double salary)
        {
            emp.Add(new employee { Eid = eid, Ename = ename, Designation = designation, Salary = salary });
        }
        public void show()
        {
            foreach (employee e in emp)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.Eid, e.Ename, e.Designation, e.Salary);
            }
            Console.WriteLine("\n");
        }
            public void remove(int n)
            {
            emp.RemoveAt(n);
            }
        

    }
}
