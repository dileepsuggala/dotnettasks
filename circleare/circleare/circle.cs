using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleare
{
    class circle
    {
        private double radius;
        string st;
        public double Calculate(Func<double,double>mp)
        {
            return mp(radius);
        }
        public string uppercase(Func<string,string>uc)
        {
            return uc(st);
        }
    }
}
