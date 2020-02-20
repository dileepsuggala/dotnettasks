using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace classlib
{
    class Program
    {
        static void Main(string[] args)
        {
            calculation cl = new calculation();
            cl.no1 = 400;
            cl.no2 = 50;
            Console.WriteLine(cl.add());
            Console.WriteLine(cl.difference());
            Console.WriteLine(cl.multiply());
            Console.WriteLine(cl.division());

        }
    }
}
