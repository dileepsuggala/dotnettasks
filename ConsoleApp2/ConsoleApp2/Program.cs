using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] array = { 1, 2, 3, 4};
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            Array.Reverse(array);
            Console.WriteLine("Reversed Array : ");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
           
            /*  Console.WriteLine("enter array size");
              int size =Int.Parse( Console.ReadLine());
              int[] ary = new int[size];
              for (int i = 0; i < ary.Length; i++)
              {
                  Console.WriteLine("enter number  {0}", i + 1);
                  ary[i] = Int.Parse(Console.ReadLine());
              }
              Array.Reverse(ary);
              Console.WriteLine("reversed array is");
              foreach(int value in ary)
              {
                 Console.WriteLine(ary);
              }*/
            int[] score = { 1, 5, 6, 2,3,4,6,8,10,12 };
            int sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (score[i] % 2 == 0)
                {
                    sum = sum + score[i];
                }
            }
            Console.WriteLine("Sum:" + sum);

        }
    }
}
