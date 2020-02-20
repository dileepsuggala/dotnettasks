using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopconcept
{
    class sales
    {
            string pname;
            int quantity;
            double price;
     
       public static double totalsalesamount = 0;
       
        
        
        public string Pname
        {
           set { Pname = value; }
            get { return Pname; }
        }
        public double Quantity
        {
            set { Quantity = value; }
            get { return Quantity; }
        }
        public double Price
        {
            set { Price = value; }
            get { return Price; }
        }
        public double Salesamount
        {
            get { return price * Quantity; }
        }
        public double Totalamount
        {
            get { return totalsalesamount += Salesamount; }
        }
    }
}
