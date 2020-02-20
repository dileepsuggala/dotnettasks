using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // exam e = method();

            //  method2(e);
            car c = new car("Ap32da1211");
            car c1 = new car("AP37DF5409","pulsar","red",72000);
           Console.WriteLine( c1.showcar());
           string data =  c.showcar();
            Console.WriteLine(data);
        }

        private static void method2(exam e)
        {
            exam e1 = new exam();
            e.getdata("c++", "002", 6, "23jan2020");
            e.showdata();
        }

        private static exam method()
        {
            exam e = new exam();
            e.getdata("maths", "001", 4, "22jany2020");
            e.showdata();
            return e;
        }
    }
}
