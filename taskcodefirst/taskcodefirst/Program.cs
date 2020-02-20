using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskcodefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            showall();
          //  Insertmethod();
            //    List<product> plis = new List<product>();
            /* customercontext pct = new customercontext();
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
                 Cid = cid,
                 Cname = cname,
                 Product = new List<product> {
                     new product
                 {
                     Pid = pid,
                     Pname = pname,
                     Price = price
                 }
                 }
             });
             pct.SaveChanges();*/
        }

        private static void showall()
        {
            customercontext ctx = new customercontext();
            Console.WriteLine("customers......");
            var customers = ctx.Customers;
            foreach (var c in customers)
            {
                Console.WriteLine("{0}\t{1}\t", c.Cid, c.Cname);
            }
            Console.WriteLine("\nproducts.......\n");
            var products = ctx.Products;
            foreach (var prd in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}", prd.Pid, prd.Pname, prd.Price);
            }
            Console.WriteLine("\npurchases.....\n");
            var purchases = ctx.Purchases;
            Console.WriteLine(" {0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}{6,15}", "PurchId", "orderdate", "pid", "prd_name", "price", "custid", "custname");

            foreach (var pr in purchases)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}{6,15}", pr.Id, pr.OrderDate.ToShortDateString(), pr.Pid, pr.product.Pname, pr.product.Price, pr.Cid, pr.customer.Cid, pr.customer.Cname);

            }
        }

        private static void Insertmethod()
        {
            customercontext ct= new customercontext();
            var customers = new List<customer>
            {
                new customer{Cname="Ambica"},
                new customer{Cname="sreeshanth" },
                new customer{Cname="bharat"},
                new customer{Cname="satya"},
                new customer{Cname="vankat"}
            };
            customers.ForEach(s => ct.Customers.Add(s));
            ct.SaveChanges();
            var products = new List<product>
            {
                new product{Pname="rice",Price=76},
                new product{Pname="dal",Price=176},
                new product{Pname="detergent",Price=276},
                new product{Pname="soap",Price=86},
                new product{Pname="snaks",Price=276},
            };
            products.ForEach(p => ct.Products.Add(p));
            ct.SaveChanges();
            var purchases = new List<purchase>
            {
                new purchase{OrderDate=Convert.ToDateTime("09-02-2020"),Pid=1,Cid=2},
                new purchase{OrderDate=Convert.ToDateTime("09-02-2020"),Pid=2,Cid=1},
                new purchase{OrderDate=Convert.ToDateTime("09-02-2020"),Pid=3,Cid=2},
                new purchase{OrderDate=Convert.ToDateTime("09-02-2020"),Pid=3,Cid=3},
                new purchase{OrderDate=Convert.ToDateTime("09-02-2020"),Pid=4,Cid=4},

            };
            purchases.ForEach(pr => ct.Purchases.Add(pr));
            ct.SaveChanges();

            Console.WriteLine();
        }
        

    }
}
