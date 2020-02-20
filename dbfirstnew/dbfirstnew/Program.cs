using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbfirstnew
{
    class Program
    {
        static dileepEntities e = new dileepEntities();

        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\n1.insert in to employee\n 2.insert into dept\n 3.show employee\n 4.show dept");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        insertemp();
                        break;
                    case 2:
                        insertdepartment();
                        break;
                    case 3:
                        showemp();
                        break;
                    case 4:
                        showdept();
                        break;
                    default:
                        Console.WriteLine("nothing");
                        break;

                }
            } while (op <= 4);


            // insertemp();
            //insertdepartment();
            // showemp();
          //  showdept();

        }

        private static void showdept()
        {
            Console.WriteLine("all department data are");
            var dep = e.departments;
            foreach (var d in dep)
            {
                Console.WriteLine("{0}\t{1}\t", d.Did, d.Dname);
            }
        }

        private static void showemp()
        {
            Console.WriteLine("all employees data are");
            var emp = e.emps;
            foreach (var em in emp)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", em.Eid, em.Ename, em.Designation, em.Did);
            }
        }

        private static void insertdepartment()
        {
            Console.WriteLine("enter did");
            string did = Console.ReadLine();

            Console.WriteLine("enter dname");
            string dname = Console.ReadLine();

            var dep = new department
            {
                Did = did,
                Dname = dname,

            };
            e.departments.Add(dep);
            e.SaveChanges();
        }

        private static void insertemp()
        {
            Console.WriteLine("enter Eid");
            string eid = Console.ReadLine();

            Console.WriteLine("enter Ename");
            string ename = Console.ReadLine();


            Console.WriteLine("enter Designation");
            string designation = Console.ReadLine();


            Console.WriteLine("enter Did");
            string did = Console.ReadLine();

            var Emp = new emp
            {
                Eid = eid,
                Ename = ename,
                Designation = designation,
                Did = did,
            };
            e.emps.Add(Emp);
            e.SaveChanges();
        }
    }
}
