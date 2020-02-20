using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class train:roadway
    {
        public void showtrain()
        {
            Console.WriteLine("from train");
        }
        public override void show()
        {
            //
          //base.show();
            Console.WriteLine("train track is perfect");
        }
    }
}
