using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task28
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\DS\hi.txt";
            filecreate fc = new filecreate();
            int op;
            do
            {

                Console.WriteLine("\n1.create\t2.display\t3.append\t4.delete\t5.quit");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: fc.create(path); break;
                    case 2: fc.display(path); break;
                    case 3: fc.append(path); break;
                    case 4: fc.delete(path); break;

                }
            } while (op <= 4);
        }
    }
}
