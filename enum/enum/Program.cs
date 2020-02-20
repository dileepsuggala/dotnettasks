using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        enum department
        {
            physics = 19,
            chemistry,
            maths = 20,
            biology = 31

        }
        static void Main(string[] args)
        {
            
        Console.WriteLine("department id of physics is{0}",(int)department.physics);
            Console.WriteLine("department id of chemistry is{0}",(int)department.chemistry);
         
        }
        
    }
}
