using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ename;
            Console.WriteLine("enter  your name");
            ename = Console.ReadLine();
                Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("congratulations mr/ms {0} on your {1} birthday",ename,age);
            Console.ReadKey();
        }
    }
}
