using HRLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    internal class IComparerDemo
    {
        static void Main(string[] args)
        {
            List<Department> deptlist = new List<Department>();
            deptlist.Add(new Department { Deptno = 110, DeptName = "purchase", Location = "Bangalore" });

            deptlist.Add(new Department { Deptno = 20, DeptName = "sales", Location = "Tokyo" });


            deptlist.Add(new Department { Deptno = 4, DeptName = "hr", Location = "Chennai" });

            deptlist.Add(new Department { Deptno = 10, DeptName = "logistics", Location = "Pune" });

            Department sorted = new Department();
            deptlist.Sort(sorted);

            
            foreach (var item in deptlist)
            {
                Console.WriteLine(item.Deptno);
                Console.WriteLine(item.DeptName);
                Console.WriteLine(item.Location);
                Console.WriteLine("-------");
            }

            Console.Read();
        }
    }
}
