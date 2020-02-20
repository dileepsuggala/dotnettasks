using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, fact = 1;
            Console.WriteLine("enter number");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<n;i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("the factorial of {0} is {1}", n, fact);
        }
    }
}
