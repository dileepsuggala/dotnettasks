using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregation
{
    class employee
    {
        int id;
        string address;
        string name;
        public int Id { get; set; }
        public string Address { get; set;}
        public string Name { get; set; }
        public dept dp { get; set; }
        public virtual string empsalary(double sal)
        {
            return sal.ToString();
        }
    }
}
