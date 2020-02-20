using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacexample
{
    class Program
    {
        static void Main(string[] args)
        {
            //   doit d = new doit();
            //   d.getit();
            bikedrone bd = new bikedrone { b = new bike { price = 72000,no=  "2317",year=  2017 } };
            bd.drone();
            bd.mshow();
            Console.WriteLine("price is {0}\n no is {1}\n year is {2} ",bd.b.price,bd.b.no,bd.b.year);
        }
    }
}
