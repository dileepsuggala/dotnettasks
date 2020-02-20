using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractcl
{
    class circle:shape
    {
        
        public double radius;
        public circle(double r)
        {
            radius = r;
        }
        public override double area()
        {
            double rad;
            rad = radius;
            // throw new NotImplementedException();
            Console.WriteLine("circle area");
            return (rad * rad * Math.PI);
       }
    }
}
 