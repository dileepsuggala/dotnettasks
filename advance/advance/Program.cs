using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance
{
    class Program
    {
        public delegate void mydelg(string s);
        static void Main(string[] args)
        {
            string str = "twinkle twinkle little star";
            int b = str.wordcount();
            Console.WriteLine(b);

            mydelg delgt = a => Console.WriteLine(a);
            delgt("hello");
            Func<int, double, double> Calc = (x, y) => x * y;
            Console.WriteLine(Calc(12, 10.8));

            int[] nos = { 45, 23, 12, 98, 65 };
            var sort = nos.OrderBy(x => x);
            Console.WriteLine(string.Join(" ",sort));

            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            int i = s.wordcount();
            Console.WriteLine("no of words:{0}", i);
        }
    }
}
