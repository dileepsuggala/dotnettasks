using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //object of trainee class
            getobj1();

            getobj2();

           // getobj3();
        }

        private static void getobj3()
        {
            trainee tr2 = new trainee();
            tr2.getdata("suggala", "", "chennai", 22);
            tr2.showdata();
        }

        private static void getobj2()
        {
            trainee tr1 = new trainee();
            tr1.getdata("subrahmanyam", "17", "chennai", 22);
            tr1.showdata();
        }

        private static void getobj1()
        {
            trainee tr = new trainee();
            tr.getdata("dileep", "emp093", "chennai", 21);
            tr.showdata();
        }
    }
}
