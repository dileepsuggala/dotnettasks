using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregation
{
    class Program
    {
        public static void Main(string[] args)
        {
            product p = new product() {Pid =21,Name = "mobile",Price = 20000,c = new category {Cid = 1233,Description = "get the best" } };
            Console.WriteLine("product id :{0}\n name:{1}\n price:{2}\n", p.Pid, p.Name, p.Price);
            Console.WriteLine("category id is {0}\n description: {1} ", p.c.Cid, p.c.Description);




            //    aggregation();
            /*  Demo d1 = new Demo(20, 50);
              d1.showData();
              Demo d2 = new Demo(10, 50);
              d2.showData();
              Demo s = new Demo();
                  s = d1 + d2;
              s.showData();*/


        }

      /*  private static void aggregation()
        {
            employee e = new employee
            {
                Id = 1,
                Name = "dileep",
                Address = "bluelotus",
                dp = new dept { Depid = 1, D_name = "production" }
            };
            Console.WriteLine("employee id :{0}\n name:{1}\n Address:{2}\n", e.Id, e.Name, e.Address);
            Console.WriteLine("deptid is {0}\n dep nameis {1} ", e.dp.Depid, e.dp.D_name);
            Console.WriteLine("salary is {0}\n", e.empsalary(24000));

            analyst al = new analyst { Id = 323, Name = "suggala", dp = new dept { Depid = 3, D_name = "costruction" } };
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", al.Id, al.Name, al.dp.Depid, al.dp.D_name);
            al.empsalary(24000);
            Console.WriteLine("salary is {0}", al.empsalary(24000));
        }*/
    }
}
