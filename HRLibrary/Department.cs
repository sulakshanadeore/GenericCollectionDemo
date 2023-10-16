using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Department:IComparer<Department>
    {
        public int Deptno { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }

        public int Compare(Department x, Department y)
        {
            //throw new NotImplementedException();
            Department d1= x as Department;
            Department d2= y as Department; 
            return d1.Deptno.CompareTo(d2.Deptno);

        }
    }
}
