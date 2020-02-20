using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseclass
{
    public class A
    {
        public int _value = 6; 
    }
    public class B : A
    {
        public new int _value = 7;
        public void write()
        {
            Console.WriteLine(base._value);
            Console.WriteLine(this._value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            B b = new B();
            b.write();

        }
    }
}
