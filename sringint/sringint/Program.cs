using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sringint
{
    class Program
    {
        public static string greetings(int age, string name)
        {
          
            return string.Format("congratulations {0}  on your {1} birthday",name,age);
            
        }

        static void Main(string[] args)
        {
            int age;
            string name, res;
            Console.WriteLine("enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
           res =  greetings(age, name);
            Console.WriteLine(res);
        }
    }
}
