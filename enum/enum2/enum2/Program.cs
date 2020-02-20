using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{
    class Program
    {
        enum weekdays
        {
            sunday=1,
            monday=2,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday

        }
        static void Main(string[] args)
        {
            Console.WriteLine("the day is {0}", (int)weekdays.wednesday);
        }
    }
}
