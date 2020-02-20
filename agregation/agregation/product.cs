using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregation
{
    class product
    {
        int pid;
        string name;
        double price;
        public int Pid { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public category c { get; set; }
    }
}
