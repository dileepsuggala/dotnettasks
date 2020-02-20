using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string1
{
    class Program
    {
        public class person
        {
          public  string firstname;
            public string lastname;

            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }
   public     static void Main(string[] args)
        {


            string strlong = "how are you ? i am fine ,ehat about you ?";
            string[] sts = strlong.Split('?', ',');
            foreach (string st in sts)
            {
                Console.WriteLine(st);
            }


            Console.WriteLine("enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] ary = new string[size];
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine("enter word  {0}", i + 1);
                ary[i] = Console.ReadLine();
            }
            Console.WriteLine(joinstrArray(ary));
            join();

            concat();

            strsplit();

            string joinstrArray(string[] ar)

            {
                return String.Join(" ", ar);
            }

        }

        private static void join()
        {
         
            string[] names = new string[] { "dileep", "suggala", "subrahmanyam" };
            string allnames = string.Join("", names);
            Console.WriteLine(allnames);
        }

        private static void concat()
        {
            person p = new person();
            Console.WriteLine("enter firstname and lastname");
            p.Firstname = Console.ReadLine();
            p.Lastname = Console.ReadLine();

            Console.WriteLine(string.Concat(p.Firstname, p.Lastname));
        }

        private static void strsplit()
        {
            string st1 = "dileep subrahmanyam suggala";
            string[] words = st1.Split();
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}
