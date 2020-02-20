using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdtask28
{
    class Program
    {
        static void Main(string[] args)
        {
            var ptdetails = new Gencl<product>();
            ptdetails[0] = new product
            {
                Id = 093,
                Pname = "mobile",
                Price = 20000
            };
            ptdetails[1] = new product
            {
                Id = 386,
                Pname = "laptop",
                Price = 30000
            };
            Console.WriteLine("{0}\t{1}\t{2}", ptdetails[0].Id, ptdetails[0].Pname, ptdetails[0].Price);
            Console.WriteLine("{0}\t{1}\t{2}", ptdetails[1].Id, ptdetails[1].Pname, ptdetails[1].Price);
        }
    }
    
}
