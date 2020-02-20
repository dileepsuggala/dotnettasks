using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregateoverride
{
    class fixedamount:bank
    {
        public override string intrestamount(double balance)
        {
            double fixedamountinterest = 0.06 * balance;
            double totalbalance = balance + fixedamountinterest;
            return totalbalance.ToString();
         
        }
    }
}
