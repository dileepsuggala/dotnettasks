using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelfirstnew
{
    class Program
    {
        static ModelfirstnewContainer mfc = new ModelfirstnewContainer();
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\n1.insert category\n 2.insert product\n 3.show category\n 4.show product");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        insertcat();
                        break;
                    case 2:
                        insertpro();
                        break;
                    case 3:
                        getcat();
                        break;
                    case 4:
                        getpro();
                        break;
                    default:
                        Console.WriteLine("nothing");
                        break;

                }
            } while (op <= 4);

            //  insertcat();

                //  insertpro();
                //  getcat();
                // getpro();

        }

        private static void getpro()
        {
            Console.WriteLine("all products are");
            var pr = mfc.pros;
            foreach (var p in pr)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", p.pid, p.ptype, p.price, p.cid);
            }
        }

        private static void getcat()
        {
            Console.WriteLine("all categories are ");
            var cat = mfc.cats;
            foreach (var c in cat)
            {
                Console.WriteLine("{0}\t{1}\t", c.cid, c.ctitle);
            }
        }

        private static void insertpro()
        {
            Console.WriteLine("enter product id");
            int Pid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter product type");
            string Ptype = Console.ReadLine();

            Console.WriteLine("enter price");
            double Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter cid");
            int Cid = int.Parse(Console.ReadLine());
            var pr = new pro
            {
                pid = Pid,
                ptype = Ptype,
                price = Price,
                cid = Cid,
            };
            mfc.pros.Add(pr);
            mfc.SaveChanges();
        }

        private static void insertcat()
        {
            Console.WriteLine("enter category id");
            int Cid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter category title");
            string Ctitle = Console.ReadLine();

            var Cat = new cat
            {
                cid = Cid,
                ctitle = Ctitle,

            };
            mfc.cats.Add(Cat);
            mfc.SaveChanges();
        }
    }
}
