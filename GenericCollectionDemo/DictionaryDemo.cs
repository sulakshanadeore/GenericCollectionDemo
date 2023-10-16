using HRLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    internal class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();            //int---Key, string--value
            dic.Add(1, "Ajay");
            dic.Add(2, "Kajal");
            dic.Add(5, "Sujay");

            //TryGetValue--method, takes 2 parameters,1st para----int value representing  the key and second para is string, which it returns if the key value pair exists in the dic object.
            //Try getting a value if it exists and so returns bool to tell, whether it exists or not.
            //string name = null;
            //bool ans=dic.TryGetValue(2, out name);
              bool ans = dic.TryGetValue(3, out string name);

            
            Console.WriteLine($"Answer={ans}");
            Console.WriteLine($"Value of key ={name}");
            //dic.Clear();


            Dictionary<int, string> second_dic = new Dictionary<int, string>();
            second_dic.Add(1, "Ajay");
            second_dic.Add(2, "Jack");
            second_dic.Add(3, "Payal");
            second_dic.Add(5, "Sujay");
            Console.WriteLine("Concatenated Dictionaries");
            //dic.concat concatenates 2 sequences, not necessarily 2 dictionaries, it can be any sequence that has key,value pair and where key is int , value is string.
            IEnumerable<KeyValuePair<int,string>> concatenatedObj=dic.Concat(second_dic);

            foreach (KeyValuePair<int,string> item in concatenatedObj)
            {
                Console.WriteLine(item.Key + " "  + item.Value);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Intersected Dictionaries");
            IEnumerable<KeyValuePair<int, string>> intersectedObj = dic.Intersect(second_dic);
            foreach (KeyValuePair<int, string> item in intersectedObj)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("---------------------------------");
            //Except means exists in dic, but doesn't exist in second dic

            //key value pairs--dic
            IEnumerable<KeyValuePair<int, string>> exceptObj = dic.Except(second_dic);
            Console.WriteLine("Except Dictionaries");
            foreach (KeyValuePair<int, string> item in exceptObj)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine($"Number of elements in dic object={dic.Count}");
            Console.WriteLine(  "convert dic To  a list ");
            List<KeyValuePair<int, string>> listdata=dic.ToList();
            
            foreach (KeyValuePair<int,string> item in listdata)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.WriteLine(  "----------------");
            Console.WriteLine(  "convert dic to array.....");
            KeyValuePair<int, string>[] arr = dic.ToArray<KeyValuePair<int, string>>();
            foreach (var item in arr)
            {
                Console.WriteLine(item.Key + "    " + item.Value);
            }
            Console.WriteLine("--------------------------");

            Console.WriteLine(  "Dictionary Employee");
            Dictionary<DateTime, Employee> empdict = new Dictionary<DateTime, Employee>();
            empdict.Add(new DateTime(2022,02,15), new Employee {Empid=1,Ename="Suraja",Deptno=10,Salary=10000 });
             empdict.Add(new DateTime(2021,03,11),new Employee {Empid=2,Ename="Gauri",Deptno=10,Salary=9999 });
            empdict.Add(new DateTime(2021, 03, 12), new Employee { Empid = 3, Ename = "Simran", Deptno = 10, Salary = 877 });

            Dictionary<DateTime, Employee> empdict1 = new Dictionary<DateTime, Employee>();
            empdict1.Add(new DateTime(2022, 02, 15), new Employee { Empid = 1, Ename = "Suraj", Deptno = 10, Salary = 10000 });
            empdict1.Add(new DateTime(2021, 03, 11), new Employee { Empid = 2, Ename = "Gaurish", Deptno = 10, Salary = 9999 });
            empdict1.Add(new DateTime(2021, 03, 12), new Employee { Empid = 6, Ename = "Ram", Deptno = 10, Salary = 877 });

            IEnumerable<KeyValuePair<DateTime,Employee>> exceptEmployees=empdict.Except(empdict1);
            

            //IEnumerable<KeyValuePair<DateTime, Employee>> exceptEmployees = empdict.Except(empdict1,(empdict) new IEqualityComparer<Employee> empdata);

            Console.WriteLine("Except employees");
            Console.WriteLine("datafollows");
            foreach (var item in exceptEmployees)
            {
                Console.WriteLine(  item.Key + " " + item.Value.Empid +" " + item.Value.Ename);
            }

            Console.WriteLine("==================");


            //foreach (var item in empdict)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value.Empid + " "+ item.Value.Ename);
            //}
            //IOrderedEnumerable<KeyValuePair<DateTime,Employee>> orderedbyJoiningDate =empdict.OrderBy(e => e.Key);
            //Console.WriteLine("Sort on the basis of Datetime");
            //foreach (var item in orderedbyJoiningDate)
            //{
            //    Console.WriteLine(item.Key);
            //}
            //not type safe
            //Hashtable h = new Hashtable();
            //h.Add(1, "A");
            //h.Add(2,2);

            ////type safe
            //Dictionary<int, int> dic1 = new Dictionary<int, int>();
            //dic1.Add(1,10);
            //dic1.Add(1, 10);

            Console.ReadLine();



        }
    }
}

