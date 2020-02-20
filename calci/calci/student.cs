using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calci
{
    class student
    {
        string name;
        int id;
        string course;
        DateTime joindate;
        string firstname;
        string lastname;
        public student() { }
        public student(string fn, string ln)
        {
             firstname = fn;
             lastname = ln;
        }

        public string Name    //read and write properties
        {
            get { return string.Format("{0} {1}", firstname, lastname); }
            
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public  string Course
        {
            set { course = value; }
            get { return course; }
            
        }
        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }

    }
}
