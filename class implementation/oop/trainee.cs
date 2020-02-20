using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class trainee
    {
        //data fields
        string name, id, address;//instance variables
        int age;
        public void getdata(string nm,string id,string adr,int ag)
        {
            name = nm;
            this.id = id;// converting local variable to current class variable
            address = adr;
            age = ag;
        }

        public void showdata()
        {
            Console.WriteLine(name);
            Console.WriteLine(id + " " + address);
            Console.WriteLine(age);
           
        }
    }
}
