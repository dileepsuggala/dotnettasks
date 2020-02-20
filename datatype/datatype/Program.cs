using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'G';
            byte b = 255;
            short s = 359;
            int n = 999;
            uint ui = 99999;
            long l = 10398959;
            float f = 10.95f;
            decimal m = 109.45m;
            DateTime dt = DateTime.Now;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(f);
                Console.WriteLine(m);
            Console.WriteLine("the current date is :{0}" + "character is {1}" + "byte b is {2}" + "short is {3}" + "int is {4}" + "uint is {5}" + "long is {6}" + "float is {7}" + "decimal is {8}",dt,a,b,s,n,ui,l,f,m );
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortTimeString());
            
        }
    }
}
