using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleare
{
    class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            Console.WriteLine("enter radius of a circle");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(c.Calculate(x => 2*(p + p * p)));
            Console.WriteLine(c.Calculate(r => 2 * Math.PI * p));
            Console.WriteLine();
            Console.WriteLine(c.Calculate(r => Math.PI * p * p));
            Console.WriteLine(c.Calculate(a => p * p * p));
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            Console.WriteLine(c.uppercase(a => s.ToUpper()));
            string t = "IN UPPER CASE";
            Console.WriteLine(c.uppercase(a => t.ToLower()));
        }
    }
}
