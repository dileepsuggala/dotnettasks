using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlstructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a >= 10)
                Console.WriteLine("good morning");
            else if (a < 10)
                Console.WriteLine("good evening");
            else
                Console.WriteLine("good night");

            int b = 2;
            switch(b)
            {
                case 1:Console.WriteLine("hi,how r u?");
                    break;
                case 2:Console.WriteLine("hi,how do u do?");
                    break;
                case 3:Console.WriteLine("hope you are doing well");
                    break;
                default:Console.WriteLine("it seems that you are not good");
                    break;
            }
            Console.WriteLine("enter your number");
            int n = int.Parse(Console.ReadLine());
           
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);

            }
            int m = 10;
            while(m<100)
            {
                Console.WriteLine("{0} is less than 100", m);
                m = m + 10;
            }
            do
                {
                Console.WriteLine("{0} is  < 100", m);
            }while (m > 100) ;


        }
    }
}
