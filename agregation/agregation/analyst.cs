﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregation
{
    class analyst:employee
    {
        public override string empsalary(double sal)
        {
            // return base.empsalary(sal);
            double incentive = 4000;
            double total = incentive + sal;
            return total.ToString();
        }

    }
}
