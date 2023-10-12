using HRLibrary;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GenericCollectionDemo
{
    internal class Program
    {
   public   static  EmpManagement mgt = new EmpManagement();
        private static void showList()
        {
            
            Console.WriteLine("The employee list");
            List<Employee> emplist = new List<Employee>();
            emplist=mgt.ShowEmployeeList();
            foreach (var item in emplist)
            {
                Console.WriteLine(item.Empid);
                Console.WriteLine(item.Ename);
                Console.WriteLine(item.Salary);
                Console.WriteLine(item.Deptno);
                Console.WriteLine("----------");
            }
       }

        private static void FindEmployeeByID() 
        {
            
            Employee emp = new Employee();
            Console.WriteLine("Enter employeeid");
            emp.Empid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(  "Enter name");
            emp.Ename=Console.ReadLine();

            Employee empobj=mgt.FindEmployee(emp.Empid, emp.Ename);
            if (empobj != null)
            {
                Console.WriteLine(empobj.Empid);
                Console.WriteLine(empobj.Ename);
                Console.WriteLine(empobj.Salary);
                Console.WriteLine(empobj.Deptno);
            }
            else
            {
                Console.WriteLine("No such employee exists.....");

            }

        }


        static void Main(string[] args)
        {
            //StackAndQueue();
            //List<int> list = new List<int>();

            string ans = null;
            do
            {
                Console.WriteLine("Menu");
            Console.WriteLine("1.Show All Employees \n2.FindEmployeeById and Name \n3.FindEmployees By Deptno \n4.Add Employee  \n5.Delete Employee \n6.UpdateEmployeeData \n7.Exit");
           

                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        showList();
                        break;

                    case 2:
                        FindEmployeeByID();
                        break;
                    case 3:
             
                        Console.WriteLine("Enter deptno");
                        int deptno = Convert.ToInt32(Console.ReadLine());
                        List<Employee> EmployeesInDept = mgt.FindEmployeesByDeptno(deptno);
                        foreach (var item in EmployeesInDept)
                        {
                            Console.WriteLine($"EmployeeID={item.Empid}");
                            Console.WriteLine($"Employee Name={item.Ename}");
                            Console.WriteLine($"Salary=Rs. {item.Salary}");
                            Console.WriteLine($"Deptno={item.Deptno}");
                            Console.WriteLine("---------");
                        }

                        break;
                    case 4:
             
                        Employee empadd = new Employee();
                        Console.WriteLine("enter employee id");
                         empadd.Empid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee name");
                        empadd.Ename = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        empadd.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Deptno");
                        empadd.Deptno = Convert.ToInt32(Console.ReadLine());

                        mgt.AddEmployeeToList(empadd);
                        Console.WriteLine("Showing the added employee");

                        showList();


                        break;
                    case 5:
             
                        Console.WriteLine("Enter the empid to delete");
                        int empid=Convert.ToInt32(Console.ReadLine());
                        int c=mgt.RemoveEmployeeFromList(empid);
                        Console.WriteLine($"Removed {c} employee with employeeid{empid}");

                        break;

                    case 6:
                      
                        Employee e1 = new Employee();
                        Console.WriteLine("enter employee id");
                        e1.Empid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter employee name");
                        e1.Ename = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Deptno");
                        e1.Deptno = Convert.ToInt32(Console.ReadLine());

                        mgt.UpdateEmployeeDatainList(e1);

                        break;
                    case 7:
                        Environment.Exit(1);
                        break;

                }
                Console.WriteLine(" do u want to continue");
                ans = Console.ReadLine();
            }
            while ( ans=="Yes" || ans=="yes");
            Console.ReadLine();

            
        





            //int CountOfRemovedEmployees=emplist.RemoveAll(edata => (edata.Deptno ==20 && edata.Salary==100000));
            //Console.WriteLine($"No of employees deleted/removed from the list= {CountOfRemovedEmployees}");

            //bool res=  emplist.Remove(e1);
            //emplist.RemoveAt(0);
            //emplist.RemoveRange(0, 2);

            //if (res)
            //{
            //    Console.WriteLine("Employee removed successfully...");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not removed......");
            //}


            Console.WriteLine("--------" );


            //foreach (var item in emplist)
            //{
            //    Console.WriteLine(item.Empid);
            //    Console.WriteLine(item.Ename);
            //    Console.WriteLine(item.Salary);
            //    Console.WriteLine(item.Deptno);
            //    Console.WriteLine("----------");
            //}




            Console.ReadLine();







        }

        private static void StackAndQueue()
        {
            //Generic brackets--datatype (the type of data that we want to store in the collection)
            Stack<int> Sobj = new Stack<int>();
            Stack<Employee> empstack=new Stack<Employee>();
            Employee e = new Employee();
            e.Empid = 1;
            e.Ename = "Raj";
            e.Salary = 100000;
            e.Deptno = 20;
            empstack.Push(e);

            Sobj.Push(1);
            Sobj.Push(2);
            Sobj.Push(31);
            Sobj.Push(131);
            Sobj.Push(15);
            Sobj.Push(156);
            Sobj.Push(1115);
            Sobj.Push(11);
            foreach (int i in Sobj)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------");
            int poppedObj = Sobj.Pop();
            Console.WriteLine(poppedObj);
            Console.WriteLine("---------------");

            Queue<String> queue = new Queue<String>();
            queue.Enqueue("hello");
            queue.Enqueue("helloworld");
            queue.Enqueue("welcome");
            queue.Enqueue("good morning");
            queue.Enqueue("good day");
            queue.Enqueue("hello");

            queue.Dequeue();
        }
    }
}
