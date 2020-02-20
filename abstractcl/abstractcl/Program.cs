using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractcl
{
    class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle(2);
            double r = c.area();
            Console.WriteLine("area:{0}", r);

        }
    }
}
