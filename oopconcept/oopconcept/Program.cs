using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopconcept
{
    class Program
    {
        static void Main(string[] args)
        {
            sales s1 = new sales();
            s1.Pname = "cake";
            s1.Quantity = 3;
            s1.Price = 120;
            Console.WriteLine("{0}\t {1}",s1.Pname);
            Console.WriteLine(s1.Salesamount);
            Console.WriteLine(s1.Totalamount);
            
            sales s2 = new sales();
            s1.Pname = "choclates";
            s1.Quantity = 6;
            s1.Price = 12;
            Console.WriteLine("{0}\t {1}", s2.Pname);
            Console.WriteLine(s2.Salesamount);
            Console.WriteLine(s2.Totalamount);
            Console.ReadKey();



            // Program prg = new Program();
            //  methodoverloading();
            //   prg.nonstaticmethod();
        }
       /* public void nonstaticmethod()
        {
            Console.WriteLine("it is non static");
        }
        private static void methodoverloading()
        {
            calculate clt = new calculate();
            Console.WriteLine(clt.area(12));
            Console.WriteLine(clt.area(10, 20));
            Console.WriteLine(clt.area(15.7));
            Console.WriteLine(clt.area(10.6, 9));
        }*/
    }
}
