using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringcon
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "helloworld!";
            Console.WriteLine(data);
            string a = data.Insert(6, "my ");
            string bn = "you are so nice";
            Console.WriteLine(a);
            Console.WriteLine(String.Concat(a, bn));
            string up = data.ToUpper();
            string lc = up.ToLower();
            Console.WriteLine("substring {0}", bn.Substring(4, 4));
            Console.WriteLine("{0}\t{1}", up, lc);
            string[] names = new string[] { "Anand", "Raju", "Munna" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",", names);
            Console.WriteLine(allnames);
            string st1 = "welcome to c#";
            string[] words = st1.Split();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            string nstr = string.Copy(st1);
            Console.WriteLine("copied string is{0}", nstr);
            int i = st1.IndexOf("to");
            Console.WriteLine("index of {0} is",i);
            int l = st1.Length;
            Console.WriteLine("length of string {0}", 1);
            words.Reverse();
            foreach(string w in words)
                {
                Console.WriteLine(w);
            }
            int nx = string.Compare("hello", "hello");
            Console.WriteLine("comparision is {0}", nx);
        }
    }
}
