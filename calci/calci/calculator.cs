using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calci
{
    class calculator
    {
        int a,b,c;
        

        public int add(int a,int b)
        {
                c = a + b;
            return c;
        }
        public int difference(int a,int b)
        {
            c= a - b;
            return c;
        }
        public int multiply(int a,int b)
        {
           c=  a * b;
            return c;
        }
        public int divide(int a,int b)
        {
            c= a / b;
            return c;
        }

       
    }
}
