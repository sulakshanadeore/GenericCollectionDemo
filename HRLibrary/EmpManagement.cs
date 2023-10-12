using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class EmpManagement
    {
          static List<Employee> emplist = new List<Employee>();
        public EmpManagement()
        {
            ////Populating the data
            Employee e = new Employee();
            e.Empid = 1;
            e.Ename = "Raj";
            e.Salary = 100000;
            e.Deptno = 20;
            emplist.Add(e);
            Employee e2 = new Employee(12, "Gauri", 50000, 10);
            emplist.Add(e2);
            emplist.Add(new Employee(13, "Koyal", 40000, 10));
            emplist.Add(new Employee { Empid = 14, Ename = "Hari", Deptno = 30, Salary = 60000 });

            List<Employee> newlist = new List<Employee>();

            newlist.Add(new Employee { Empid = 15, Ename = "Harish", Deptno = 20, Salary = 70000 });
            newlist.Add(new Employee { Empid = 16, Ename = "Anil", Deptno = 30, Salary = 80000 });

            emplist.AddRange(newlist);

            emplist.Insert(1, new Employee { Empid = 2, Salary = 40000, Ename = "Tina", Deptno = 10 });

            emplist.InsertRange(2,
                new List<Employee> {
                    new Employee { Empid = 3, Ename = "Priya", Salary = 100000, Deptno = 10 },  new Employee { Empid = 4, Ename = "Rajashri", Deptno=10,Salary=66668 } }
                    );
        }


        public List<Employee> ShowEmployeeList()
        { 
        return emplist;
              
        }

        public List<Employee> FindEmployeesByDeptno(int deptno)
        {
            return emplist.FindAll(edata => edata.Deptno == deptno);
        }

        public Employee FindEmployee(int empid, string ename)
        {
            Employee found=emplist.Find(efind => (efind.Empid == empid && efind.Ename == ename));
            if (found != null) {
                return found;
            }
            return null;
            
        
        }

        public void AddEmployeeToList(Employee emp)
        { 
        emplist.Add(emp);
        
        }

        public int RemoveEmployeeFromList(int empid)
        {
            int countRemoved=emplist.RemoveAll(emptoRemove => emptoRemove.Empid == empid);

            return countRemoved;

        }

        public void UpdateEmployeeDatainList(Employee newdata)
        { 
        Employee found=emplist.Find(e=>e.Empid==newdata.Empid);
            found.Ename=newdata.Ename;
            found.Salary = newdata.Salary;
            found.Deptno=newdata.Deptno;

            
            


        
        }










    }
}
