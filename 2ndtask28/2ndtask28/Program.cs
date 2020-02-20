using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndtask28
{
    class Program
    {
        public static double ar(double b, double h)
        {
            return b * h * 0.5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter base and height");
      
            Func<double, double, double> area = ar;
            double B = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            Console.WriteLine(area(B,H));
        }
    }
}
