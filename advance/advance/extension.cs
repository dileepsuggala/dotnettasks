using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance
{
  static  class extension
    {
            public static int wordcount(this string str)
            {
                return str.Split(new char[] { ' ', ',', '?' },StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }
    
}
