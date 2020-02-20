using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            // arraylist();
            //   hashtable();
            //  stack();
            //    queue();
            // slist();
            // stringlst();


        }

        private static void stringlst()
        {
            List<string> stlst = new List<string>();
            stlst.Add("programing languages:");
            stlst.Add("c#");
            stlst.Add("java");
            stlst.Add("python");
            stlst.Add("F#");
            stlst.Add("phP");
            stlst.Add("VB");

            foreach (string itm in stlst)
            {
                Console.WriteLine(itm);
            }
            stlst.Insert(3, "R");
            Console.WriteLine();
            foreach (string itm in stlst)
            {
                Console.WriteLine(itm);
            }
        }

        private static void slist()
        {
            SortedList slist = new SortedList();
            slist.Add("zameer", 234);
            slist.Add("anand", 123);
            slist.Add("krish", 213);
            slist.Add("Bhim", 678);
            foreach (string k in slist.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (string v in slist.Values)
            {
                Console.WriteLine(v);
            }
        }

        private static void queue()
        {
            Queue qu = new Queue();
            qu.Enqueue(123);
            qu.Enqueue(234);
            qu.Enqueue(432);
            foreach (int i in qu)
            {
                Console.WriteLine(i);
            }
            qu.Dequeue();
            foreach (int i in qu)
            {
                Console.WriteLine(i);
            }
        }

        private static void stack()
        {
            Stack stk = new Stack();
            stk.Push("choclate");
            stk.Push("biscuit");
            stk.Push("cake");
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
            stk.Pop();
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
        }

        private static void hashtable()
        {
            Hashtable hst = new Hashtable();
            hst.Add("raju", "1234");
            hst.Add("vimala", "5678");
            hst.Add("karan", "7676");
            foreach (string k in hst.Keys)
            {
                Console.WriteLine(k);
            }
            foreach (string h in hst.Values)
            {
                Console.WriteLine(h);
            }
            hst.Remove("karan");
        }

        private static void arraylist()
        {
            ArrayList al = new ArrayList() { "A", "B", "c", "D", "E", "F" };
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("bharat");
            al.Add("shaw");
            al.Insert(4, "dileep");
            Console.WriteLine();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Reverse();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            string[] r = new string[] { "cat", "mat" };
            al.SetRange(4, r);
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.RemoveRange(2, 2);
            Console.WriteLine();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
        }
    }
}
