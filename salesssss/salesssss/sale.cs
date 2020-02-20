using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesssss
{
    class sale
    {
        string productname;
        double quantity;
        double price;
        public static double totalsalesamount = 0;
        
        
        public string Pname
        {
            
            get { return productname; }
            set{productname =value ;}
        }
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
            
        }
        public double Price
        {
              get { return price; }
            set { price = value; }
          
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
