using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregateoverride
{
    class bank:customer
    {
        double acno;
       
        public double Acno { get; set; }
        customer cb = new customer();
           

        public override string intrestamount(double balance)
        {
            double interest = 0.03 * balance;
            
            return interest.ToString();
        }
        
    }
}
