using HRLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    internal class HashTabledemo
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "A");
            //dic.Add(2, "BA");
            //dic.Add(3, "C");
            //dic.Add(4, "D");
            //dic.Add(5, "E");

            //Dictionary<int,string>.Enumerator dicmove=dic.GetEnumerator();
            //while(dicmove.MoveNext())
            //{
            //    Console.WriteLine(dicmove.Current.Key + " " +   dicmove.Current.Value);
                
            //}

            Person p = new Person();
            p.arr = new int[] { 1, 2, 3, 4, 5, 6 };
            IEnumerable<int> arr1=p.arr.AsEnumerable();
            

            foreach (int i in arr1)
            {
                Console.WriteLine(i);

            }
            p.Reset();
            foreach (int i in p.arr)
            {
                Console.WriteLine(i);

            }



            Console.Read();

        }
    }
}


