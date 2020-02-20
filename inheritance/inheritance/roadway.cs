using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class roadway:vehicle
    {
        public virtual void show()
        {
            Console.WriteLine("roadway");
        }
    }
}
