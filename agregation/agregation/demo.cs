using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregation
{
    struct Demo
    {
        int no;
        int no1;
        
        public Demo(int a,int b)
        {
            no = a;
            no1 = b;
        }
        public void showData()
        {
            Console.WriteLine("{0}\t{1}",no,no1);
        }
        public static Demo operator +(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no = x.no + y.no;
            t.no1 = x.no1 + y.no1;
            return t;
        }
        public static Demo operator -(Demo x, Demo y)
        {
            Demo t = new Demo();
            t.no = x.no - y.no;
            t.no1 = x.no1 - y.no1;
            return t;
        
        }
    }
}
