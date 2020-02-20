using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        public static double average(int[] marks)
        {
            double sum= 0;
            double avg;

            for(int i=0;i<marks.Length;i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / marks.Length;
            return avg;
        }


        static void Main(string[] args)
        {
           
            
            string[] employee = new string[] {"rajesh","ramesh","suresh","naresh"};
            int[] marks = new int[] { 82, 91, 90, 93,88 };
            for(int i = 0;i<marks.Length;i++)
            {
                Console.WriteLine("Subject marks {0}", marks[i]);
                
            }
           
            
            for(int j = 0;j<employee.Length;j++)
            {
                Console.WriteLine("employe names {0}", employee[j]);
            }
            var avg = average(marks);
            Console.WriteLine("average is {0}", avg);
           
        }
    }
}
