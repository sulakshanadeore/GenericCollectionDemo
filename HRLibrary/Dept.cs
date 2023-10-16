using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Dept:IComparable
    {
        public int Deptno { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }

        public int CompareTo(object obj)
        {
      if (obj == null) return 1;
      Dept d=obj as Dept;
            if (d != null) 
            {
            return this.Deptno.CompareTo(d.Deptno);
            }
            else
            {
                Console.WriteLine(  "Object doesn't have deptno");
                return -1;
            }
        }
    }
}
