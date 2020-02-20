using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringcol = new somesample<string>();
            stringcol[0] = "this is a indexer demo";
            Console.WriteLine(stringcol[0]);
            stringcol[1] = "hello world";
            Console.WriteLine(stringcol[1]);

            var stdetails = new somesample<student>();
            stdetails[0] = new student
            {
                Id = 093,
                Studentname = "dileep",
                Course = "c#"
            };
            stdetails[1] = new student
            {
                Id = 386,
                Studentname = "suggala",
                Course = "web"
            };
            Console.WriteLine("{0}\t{1}\t{2}",stdetails[0].Id,stdetails[0].Studentname,stdetails[0].Course);
            Console.WriteLine("{0}\t{1}\t{2}", stdetails[1].Id, stdetails[1].Studentname, stdetails[1].Course);
        }
    }
}
