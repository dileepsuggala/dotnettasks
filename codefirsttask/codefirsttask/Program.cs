using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirsttask
{
    class Program
    {
        static void Main(string[] args)
        {
            productcontext pct = new productcontext();
            Console.WriteLine("enter product id");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product name");
            string pname = Console.ReadLine();
            Console.WriteLine("enter product price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter customer id");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name");
            string cname = Console.ReadLine();
            pct.Customer.Add(new customer
            {
                Pid = pid,
                Pname = pname,
                Price = price,
                Cid = cid,
                Cname = cname
            });
            pct.SaveChanges();


        }
    }
}
