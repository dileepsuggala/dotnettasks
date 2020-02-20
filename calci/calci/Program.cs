using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calci
{
    class Program
    {
        static void Main(string[] args)

        {
            vehicle v = new vehicle { No = 5409, Model = "pulsar", Vtype = "Twowheeler", Price = 72000 };
            Console.WriteLine("{0}\n{1}\n{2}", v.No, v.Model, v.Vtype, v.Price);

            vehicle v1 = new vehicle { No = 2317, Model = "swift", Vtype = "fourwheeler", Price = 552000 };
            Console.WriteLine("{0}\n{1}\n{2}", v1.No, v1.Model, v1.Vtype, v1.Price);

            //   inchcm();

            // automaticpropertiesdemo();

            //  timeobjmethod();

            //   student std = new student("dileep","suggala");
            //  std.Name = "dileep";
            // std.Id = 93;
            //   std.Course = "IT";
            //  std.Joindate = DateTime.Parse("2-01-2020");
            //std.Joindate = Convert.ToDateTime("2-20-2020");
            //Console.WriteLine("name is {0}\n id is {1}", std.Name, std.Id);
            //Console.WriteLine("Course : {0}\n joining date:{1}", std.Course, std.Joindate.ToString("dd-MM-yyyy"));
            /* int x, y;
             Console.WriteLine("enter the numbers");
             x = int.Parse(Console.ReadLine());
             y = int.Parse(Console.ReadLine());

             calculator cl = new calculator();

           Console.WriteLine("the addition is {0}and {1} is {2}",x,y,cl.add(x,y));
             Console.WriteLine("the difference is {0}and {1} is {2}",x,y, cl.difference(x,y));
             Console.WriteLine("the product is {0}and {1} is {2}",x,y,cl.multiply(x,y));
             Console.WriteLine("the divison is {0}and {1} is {2}",x,y,cl.divide(x,y));*/
        }

        private static void inchcm()
        {
            scale sc = new scale();
            sc.Inch = 3;
            Console.WriteLine("inches is {0} ", sc.Inch);
            sc.showCm();
        }

        private static void automaticpropertiesdemo()
        {
            product pd = new product
            {
                Id = 1, Pname = "chocolate", Price = 100
            };
            Console.WriteLine("{0}\n{1}\n{2}", pd.Id, pd.Pname, pd.Price);
        }

        private static void timeobjmethod()
            {
                timeperiod tp = new timeperiod();
                tp.Hours = 15;
                Console.WriteLine("hours:{0}", tp.Hours);
                tp.showSeconds();
            }

        
    }
}
