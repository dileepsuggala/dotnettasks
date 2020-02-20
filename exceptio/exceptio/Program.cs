using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptio
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0;
            try
            {
                Console.WriteLine("enter a no");
                int no1 = Convert.ToInt32(Console.ReadLine());
                if(no1<=0)
                {
                    throw new Exception("value must me greater than 0");
                }
                Console.WriteLine("enter 2nd number");
                int no2 = Convert.ToInt32(Console.ReadLine());
                d = no1 / no2;
            }
            catch(FormatException fe)
                {
                Console.WriteLine(fe.Message);
                }
            catch(NullReferenceException re)
            {
                Console.WriteLine(re.Message);
            }
            catch(InvalidCastException ics)
            {
                Console.WriteLine(ics.Message);
            }
            catch(DivideByZeroException dex)
            {
                Console.WriteLine(dex.Message);
            }
           catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("quotient is{0}", d);
            }
        }
    }
}
