using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            // fileIOdemo();
              string path = @"D:\DS\hell.txt";
              using (StreamWriter sw = File.AppendText(path))
              {
                  Console.WriteLine("Enter some text");
                  string s = Console.ReadLine();
                  sw.WriteLine(s);
              }
              using (StreamReader sr = File.OpenText(path))
              {
                  string s;
                  while((s =sr.ReadLine())!=null)
                  {
                      Console.WriteLine(s);
                  }
              }
          


           // filedemo();
        }

        private static void filedemo()
        {
            string path = @"D:\DS\hello.txt";
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter you name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your city");
                    string city = Console.ReadLine();
                    Console.WriteLine("Enter your id");
                    string id = Console.ReadLine();
                    sw.WriteLine("name:" + name);
                    sw.WriteLine("City:" + city);
                    sw.WriteLine("Id:" + id);
                    // sw.Flush();
                }
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                // sr.ReadToEnd();
            }
        }
    }
    } 
