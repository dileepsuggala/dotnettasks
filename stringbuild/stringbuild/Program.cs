using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuild
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder("hello");
            Console.WriteLine(stb);
            stb.Append(23445);
            Console.WriteLine("appended long values{0}",stb);
            int i = stb.Capacity;
            Console.WriteLine("initial capacity of stringbuilder is {0}", i);
            stb.Insert(6, "world");
            Console.WriteLine("inserted at 6 is {0}", stb);
            stb.Remove(7, 3);
            Console.WriteLine("after removing {0}", stb);
            stb.Replace("lo", "arious");
            Console.WriteLine("after replacing {0}", stb);
            stb.Clear();
            Console.WriteLine("after clear {0}", stb);

            



        }
    }
}
