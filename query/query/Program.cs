using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace query
{
    class Program
    {
        static void Main(string[] args)
        {
            List<course> clst = new List<course>()
            {
                new course{Cid =1,Cname= "c#",Fees = 7000,Startdate= Convert.ToDateTime("11-02-2020") },
                 new course{Cid =2,Cname= "css",Fees = 5000,Startdate= Convert.ToDateTime("02-02-2020") },
                  new course{Cid =3,Cname= "ADO.net",Fees = 4000,Startdate= Convert.ToDateTime("09-02-2020") },
                   new course{Cid =4,Cname= "ASP.net",Fees = 6000,Startdate= Convert.ToDateTime("06-02-2020") },
            };
            var query = from aq in clst
                        select aq;
            foreach(var q in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", q.Cid, q.Cname, q.Startdate.ToShortDateString(), q.Fees);
            }
            var qget = from gq in clst
                       where gq.Cid ==2
                        select gq;
            foreach (var q in qget)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", q.Cid, q.Cname, q.Startdate.ToShortDateString(), q.Fees);
            }
            var getq = from g in clst
                       orderby g.Fees
                       select g;
            foreach (var q in getq)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", q.Cid, q.Cname, q.Startdate.ToShortDateString(), q.Fees);
            }
        }
    }
}
