using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelfirstconsole
{
    class Program
    {
        static ModelfirstentityContainer mf = new ModelfirstentityContainer();
        static void Main(string[] args)
        {
         
            Console.WriteLine("enter product id");
            int pid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter product type");
            string ptype = Console.ReadLine();

            Console.WriteLine("enter product price");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter category id");
            int Cid2 = int.Parse(Console.ReadLine());

            var pro = new product
            {
                Pid = pid,
                Ptype = ptype,
                Price = price,
                category_cid = Cid2

            };
            mf.products.Add(pro);
            mf.SaveChanges();




                 
           
/*Console.WriteLine("enter category id");
                int Cid = int.Parse(Console.ReadLine());

                Console.WriteLine("enter category title");
                string Ctitle = Console.ReadLine();

                var Cat = new category
                {
                    cid = Cid,
                    ctitle = Ctitle,

                };
                mf.categories.Add(Cat);
                mf.SaveChanges();*/
            
        }
    }
}