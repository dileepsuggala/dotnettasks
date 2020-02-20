using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericcollections
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        public delegate string delga(int s);
        static void Main(string[] args)
        {
            // generilistdemo();
            //  hashset();
            //   stack();
            //  queue();
            //  sorteddictionary();
            //   dictionary();
            //  delegat();
            delga del = new delga(area);
            Console.WriteLine(del(5));


        }
        static string area(int s)
        {
            int A = s * s;
            return String.Format("Area of square is{0}", A);
        }
        private static void delegat()
        {
            Mydel delg = new Mydel(Add);
            Console.WriteLine(delg(12, 25));
            delg += new Mydel(Subtract);
            Console.WriteLine(delg(12, 25));
            delg -= new Mydel(Subtract);
            Console.WriteLine(delg(20, 50));
        }

        static string  Add(int x,int y)
        {
            int z = x + y;
            return String.Format("{0}+{1} ={2}", x, y, z);
        }
        static string Subtract(int x,int y)
        {
            int z = x - y;
            return String.Format("{0}-{1} ={2}", x, y, z);
        }
        private static void dictionary()
        {
            Dictionary<int, pro> dcrs = new Dictionary<int, pro>();
            dcrs.Add(1, new pro
            {
                Cname = "C#",
                Cid = 232,
                StartDate = Convert.ToDateTime("02-03-2020"),
                Fees = 6000
            });
            dcrs.Add(2, new pro
            {
                Cname = "R",
                Cid = 354,
                StartDate = Convert.ToDateTime("01-03-2020"),
                Fees = 5000
            });
            dcrs.Add(3, new pro
            {
                Cname = "ruby",
                Cid = 242,
                StartDate = Convert.ToDateTime("01-06-2020"),
                Fees = 7780
            });
            foreach (KeyValuePair<int, pro> dc in dcrs)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", dc.Key, dc.Value.Cid, dc.Value.Cname, dc.Value.StartDate.ToShortDateString(), dc.Value.Fees);
            }
        }


        private static void sorteddictionary()
        {
            SortedDictionary<int, string> sortDt = new SortedDictionary<int, string>();
            sortDt.Add(123, "chennai");
            sortDt.Add(213, "hyderabad");
            sortDt.Add(111, "vijayawada");
            foreach (KeyValuePair<int, string> ct in sortDt)
            {
                Console.WriteLine("{0}\t{1}\t", ct.Key, ct.Value);
            }
        }

        private static void queue()
        {
            Queue<pro> qcrs = new Queue<pro>();
            qcrs.Enqueue(new pro
            {
                Cname = "C#",
                Cid = 232,
                StartDate = Convert.ToDateTime("02-03-2020"),
                Fees = 6000
            });
            qcrs.Enqueue(new pro
            {
                Cname = "R",
                Cid = 354,
                StartDate = Convert.ToDateTime("01-03-2020"),
                Fees = 5000
            });
            qcrs.Enqueue(new pro
            {
                Cname = "ruby",
                Cid = 242,
                StartDate = Convert.ToDateTime("01-06-2020"),
                Fees = 7780
            });
            foreach (pro cr in qcrs)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3} ", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
        }

        private static void stack()
        {
            Stack<pro> stcr = new Stack<pro>();

            stcr.Push(new pro
            {
                Cname = "R",
                Cid = 093,
                StartDate = Convert.ToDateTime("12-02-2020"),
                Fees = 9300
            });
            stcr.Push(new pro
            {
                Cname = "cyber security",
                Cid = 092,
                StartDate = Convert.ToDateTime("11-02-2020"),
                Fees = 2000
            });
            stcr.Push(new pro
            {
                Cname = "Android",
                Cid = 067,
                StartDate = Convert.ToDateTime("10-02-2020"),
                Fees = 6000
            });
            foreach (pro cr in stcr)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3} ", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
        }

        private static void hashset()
        {
            HashSet<pro> hset = new HashSet<pro>();
            hset.Add(new pro
            {
                Cname = "bootstrap",
                Cid = 231,
                StartDate = Convert.ToDateTime("07-02-2020"),
                Fees = 3400
            });
            hset.Add(new pro
            {
                Cname = "javascript",
                Cid = 341,
                StartDate = Convert.ToDateTime("03-02-2020"),
                Fees = 2400
            });
            hset.Add(new pro
            {
                Cname = "python",
                Cid = 890,
                StartDate = Convert.ToDateTime("04-02-2020"),
                Fees = 5400
            });
            foreach (pro cr in hset)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3} ", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
        }
       
        private static void generilistdemo()
        {
          
            List<pro> courselist = new List<pro>();
            courselist.Add(new pro { Cid = 1, Cname = "c#", StartDate = DateTime.Today, Fees = 6000 });
            courselist.Add(new pro { Cid = 2, Cname = "webapps", StartDate = DateTime.Parse("05-02-2020"), Fees = 8000 });
            courselist.Add(new pro { Cid = 3, Cname = "python", StartDate = Convert.ToDateTime("08-02-2020"), Fees = 6000 });
            courselist.Sort();
            foreach(var p in courselist)
            {
                Console.WriteLine("{0}\t{1}\t{2}",p.Cid,p.Cname,p.Fees );
            }
            Predicate<pro> fst = x => x.Cid == 3;
            pro pt = courselist.Find(fst);
            Console.WriteLine("{0}\t{1}\t{2}", pt.Cid, pt.Cname, pt.Fees);
            foreach (pro cr in courselist)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3} ", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
        }
    }
}
