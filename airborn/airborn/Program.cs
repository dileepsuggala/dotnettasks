using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airborn
{
    interface Iairborne
    {
        void fly();
    }
    class Program
    {
        class helicopter:Iairborne
        {
            public void fly()
            {
                Console.WriteLine("helicopter ");
            }
        }
        class aeroplane:Iairborne
        {
            public void fly()
            {
                Console.WriteLine("aeroplane ");
            }
        }
        static void Main(string[] args)
        {
            aeroplane ar = new aeroplane();
            helicopter hr = new helicopter();
            ar.fly();
            hr.fly();
            Console.ReadKey();



        }
    }
}
