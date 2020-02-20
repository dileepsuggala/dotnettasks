using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int add(int x,int y)
        {
            int sum = x + y;
            return sum;
        }
        public static double multiply(int a,int b)
        {
            double prod = a * b;
            return prod;
        }
    
        static void Main(string[] args)
        {
            int a,b,x,y; a = 10;b = 20;x = 11;y = 12;
            double prod = multiply(a, b);
            int sum = add(x, y);
            Console.WriteLine("product of {0} and {1} = {2}", a, b, prod);
            Console.WriteLine("addition of {3} and {4} = {5}", x, y, sum);
            
           
        }
    }
}
