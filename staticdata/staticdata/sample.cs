﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticdata
{
    class sample
    {
        int no = 0;
        static int cnt = 0;
        public sample()
        {
            no++;
            cnt++;
            Console.WriteLine("no:{0}\ncount:{1}",no, cnt);
        }
        public static void show()
        {
            cnt++;
            Console.WriteLine("from static show method snd count is {0}", cnt);        }
    }
}
