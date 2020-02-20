using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace classlib2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringcol = new Class1<string>();
            stringcol[0] = "this is indexer demo done by class lib";
            Console.WriteLine(stringcol[0]);
            var stdetails = new Class1<student>();
            stdetails[0] = new student { Id = 093, Name = "dileep" };
            stdetails[1] = new student { Id = 386, Name = "suggala" };
            Console.WriteLine("{0}\t{1}\t",stdetails[0].Id,stdetails[0].Name);
            Console.WriteLine("{0}\t{1}\t", stdetails[1].Id, stdetails[1].Name);

        }
    }
}
