using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregateoverride
{
    class Program
    {
        static void Main(string[] args)
        {
            customer c = new customer
            {
                Cid = 12,Name = "dileep",Address ="chennai",b = new bank { Acno = 654345789}
            };
          Console.WriteLine("cust id is {0}\nname is{1}\n address is {2}\n", c.Cid, c.Name, c.Address);
            Console.WriteLine("acno is {0}\n", c.b.Acno);
            Console.WriteLine("balance is {0}", c.intrestamount(24000));
         
            bank bk = new bank();
            //  bank bk = new bank { Cid = 32, Name = "suggala",Address ="chennai", b = new  bank{ Acno = 3234455 } };
            // Console.WriteLine("{0}\n{1}\n{2}\n", bk.Cid, bk.Name,bk.Address, bk.b.Acno);
            // bk.intrestamount(24000);
            Console.WriteLine("simple interest  is {0}", bk.intrestamount(24000));
          //  Console.WriteLine("interest amount is{0}\n",bk.intrest(24000));
            fixedamount fd = new fixedamount();
            Console.WriteLine("fixed deposit amount with additional interest:{0}",fd.intrestamount(24000));
        }
    }
}
