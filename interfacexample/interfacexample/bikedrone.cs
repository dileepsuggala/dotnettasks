using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacexample
{
    class bikedrone:bike,Idrone
    {
        public void drone()
        {
            Console.WriteLine("leonardo");
        }
        public void mshow()
        {
            Console.WriteLine("dicarpio");
        }
        public bike b { get; set; }
    }
}
