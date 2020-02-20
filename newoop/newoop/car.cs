using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newoop
{
    class car
    {
        string regno;
        string model;
        string color;
        double price;

        public car() { }//default constructor

        public car(string reg)//overloaded
        {
            regno = reg;
        }

        public car(string reg, string mod)
        {
            regno = reg;
            model = mod;
        }
        public car (string reg,string mod,string clr,double pr)
        {
            regno = reg;
            model = mod;
            color = clr;
            price = pr;
        }
        //public void showcar()
        public string showcar()
        {
            return string.Format("Regno:{0}\n Model is {1}\nColor:{2}\n Price :{3}",regno,model,color,price);
            /*Console.WriteLine("Reg no is " + regno);
            Console.WriteLine("model is {0} ",model);
            Console.WriteLine("color is {0} and price is {1}",color,price);*/

        }


    }
}
