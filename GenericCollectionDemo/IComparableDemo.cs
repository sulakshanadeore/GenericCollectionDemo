using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace GenericCollectionDemo
{
    internal class IComparableDemo
    {
        static void Main(string[] args)
        {
            //List<int> intlist=new List<int>();
            //intlist.Add(100);
            //intlist.Add(1);
            //intlist.Add(43);
            //intlist.Add(11);
            //intlist.Add(54);
            //intlist.Sort();

            //foreach (var item in intlist)
            //{
            //    Console.WriteLine(item);
            //}




            List<Dept> deptlist=new List<Dept>();
            deptlist.Add(new Dept {Deptno=110,DeptName="purchase",Location="Bangalore" });

            deptlist.Add(new Dept { Deptno = 20, DeptName = "sales", Location = "Tokyo" });


            deptlist.Add(new Dept { Deptno = 4, DeptName = "hr", Location = "Chennai" });

            deptlist.Add(new Dept { Deptno = 10, DeptName = "logistics", Location = "Pune" });

            deptlist.Sort();
            deptlist.Reverse();
            foreach (var item in deptlist)
            {
                Console.WriteLine(  item.Deptno);
                Console.WriteLine(item.DeptName);
                Console.WriteLine(  item.Location);
                Console.WriteLine("-------");
            }

            Console.Read();

        }
    }
}
