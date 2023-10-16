using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    //Entity class----properties and validations
    public class Employee
    {
        public Employee()
        {
            
        }
        public Employee(int empid,string empname,int sal,int dno)
        {
            Empid = empid;  
            Ename = empname;
            Salary = sal;
            Deptno = dno;   
        }

        public int Empid { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }
        public int Deptno { get; set; }

    }
}
