using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27task
{
    class Program
    {
        static void Main(string[] args)
        {
            empmethod em = new empmethod();
            em.add(0, "dileep", "corporate", 20000);
            em.add(1, "doraemon", "robo", 30000);
            em.add(2, "goku","semigod", 21424);
            em.add(3, "naruto", "god", 24343);
            em.show();
            em.remove(0);
            em.show();

        }
    }
}
