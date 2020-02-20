using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class ship:vehicle
    {
         public void showship()
        {
            Console.WriteLine("from ship");
        }
      new  public void showVehicle()
        {
            Console.WriteLine("cruise liner ship");
        }
    }
}
