using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schematask
{
    class Program
    {
        static schemamodelContainer st = new schemamodelContainer(); 
        static void Main(string[] args)
        {
            showstudent();
            showschool();
            showroom();
            showinvigilator();
            showcenter();
            showcourse();
        }

        private static void showcourse()
        {
            Console.WriteLine("course data is");
            var co = st.courses;
            foreach (var c in co)
            {
                Console.WriteLine("\n\t{0}\t{1}\t\n", c.courseid, c.coursename);
            }
        }

        private static void showcenter()
        {
            Console.WriteLine("examcenter data is");
            var exam = st.examcenters;
            foreach (var e in exam)
            {
                Console.WriteLine("\n\t{0}\t{1}\t{2}\t\n", e.centerid, e.centername, e.location);
            }
        }

        private static void showinvigilator()
        {
            Console.WriteLine("ivigilator data is");
            var inv = st.invigilators;
            foreach (var i in inv)
            {
                Console.WriteLine("\n\t{0}\t{1}\t{2}\t\n", i.invigilatorid, i.iname, i.workingschool);
            }
        }

        private static void showroom()
        {
            Console.WriteLine("room data is");
            var ro = st.rooms;
            foreach (var r in ro)
            {
                Console.WriteLine("\n\t{0}\t{1}\t\n", r.roomid, r.capacity);
            }
        }

        private static void showschool()
        {
            Console.WriteLine("school data is");
            var sch = st.schools;
            foreach (var sc in sch)
            {
                Console.WriteLine("\n\t{0}\t{1}\t{2}\t\n", sc.schoolid, sc.schoolname, sc.area);
            }
        }

        private static void showstudent()
        {
            Console.WriteLine("students data is");
            var stu = st.students;
            foreach (var s in stu)
            {
                Console.WriteLine("\n\t{0}\t{1}\t{2}\t{3}\t{4}\t\n", s.sid, s.sname, s.age, s.standard, s.subject);
            }
        }
    }
}
