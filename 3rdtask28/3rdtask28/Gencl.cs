using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdtask28
{
    class Gencl<T>
    {
        private T[] arr = new T[100];
        
        public T this[int i]
        {
            get
            {
                return arr[i];
            }
            set { arr[i] = value; }
        }
    }
}
