using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class calculation
    {
        public int no1 { get; set; }
        public int no2 { get; set; }
        public string add ()
        {
            return string.Format("sum ={0}", no1 + no2);
        }
        public string difference()
        {
            return string.Format("differece ={0}", no1 - no2);
        }
        public string multiply()
        {
            return string.Format("product ={0}", no1 * no2);
        }
        public string division()
        {
            return string.Format("quotient ={0}", no1 / no2);
        }
    }
}
