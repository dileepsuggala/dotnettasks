using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesssss
{
    class Program
    {
        static void Main(string[] args)
        {
            sale s1 = new sale();
            s1.Pname = "cake";
            s1.Quantity = 3;
            s1.Price = 120;
           Console.WriteLine("productname:{0}\nquantity:{1}\nprice:{2}", s1.Pname,s1.Quantity,s1.Price);
            Console.WriteLine(s1.Salesamount);
            Console.WriteLine(s1.Totalamount);
//s1.pro();
            sale s2 = new sale();
            s2.Pname = "choclates";
            s2.Quantity = 6;
            s2.Price = 12;
            Console.WriteLine("productname:{0}\nquantity:{1}\nprice:{2}", s2.Pname,s2.Quantity,s2.Price);
            Console.WriteLine(s2.Salesamount);
            Console.WriteLine(s2.Totalamount);
            Console.ReadKey();
        }
    }
}
