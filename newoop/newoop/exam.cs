using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newoop
{
    class exam
    {
        string subject, scode;
        float credits;
        string date;

        public void getdata(string sub, string scode, float cre,string dt)
        {
            subject = sub;
            this.scode = scode;
            credits = cre;
            date = dt;
        }
        public void showdata()

        {
            Console.WriteLine(subject);
            Console.WriteLine(scode);
            Console.WriteLine(credits);
            Console.WriteLine(date);

        }


    }
}
