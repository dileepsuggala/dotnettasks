using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24febtask
{
  
    class Program
    {
        public static  double ar(double b,double h)
        {
            return b * h * 0.5;
        } 
        public static double rectar(double l,double b)
        {
            return l * b;
        }
        static void Main(string[] args)
        {
            // numbertoword();


            Func<double, double, double> area = ar;
            Console.WriteLine("enter base and heiht for triangle area");
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(area(b, h));
            Func<double, double, double> rectarea = rectar;
            Console.WriteLine("enter length and breadth for rectangle area");
            double l = double.Parse(Console.ReadLine());
            double br = double.Parse(Console.ReadLine());

            Console.WriteLine(rectarea(l,b));
            

        }

        private static void numbertoword()
        {
            int val, next, num_digits;
            int[] a = new int[10];
            string[] digits_words = {
                    "zero",
                    "one",
                    "two",
                    "three",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine"
                    };
            // number to be converted into words
            Console.WriteLine("enter number");
            val = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + val);
            Console.Write("Number (words): ");
            next = 0;
            num_digits = 0;
            do
            {
                next = val % 10;
                a[num_digits] = next;
                num_digits++;
                val = val / 10;
            } while (val > 0);
            num_digits--;
            for (; num_digits >= 0; num_digits--)
                Console.Write(digits_words[a[num_digits]] + " ");
            Console.ReadLine();
        }
    }
}
        
    

