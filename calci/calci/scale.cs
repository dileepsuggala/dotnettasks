using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calci
{
    class scale
    {
        double cm;
        public double Inch
        {
            get { return cm / 2.54; }
            set { cm = value * 2.54; }

          
        }
        public void showCm()
        {
            Console.WriteLine("centimeters {0}", cm);
        }
    }
}
