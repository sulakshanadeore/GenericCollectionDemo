using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            


            //SortedList();
            //SortedSet();
            Console.ReadLine();


        }

        private static void SortedSet()
        {
            SortedSet<string> names = new SortedSet<string>();
            names.Add("Ankita");
            names.Add("Amrita");
            names.Add("Amruta");
            names.Add("Anagha");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            SortedList<int, string> slist = new SortedList<int, string>();
            slist.Add(100, "Ankita");
            slist.Add(12, "Amrita");
            slist.Add(31, "Amruta");
            slist.Add(1, "Anagha");


            List<KeyValuePair<int, string>> sortedlist = slist.OrderBy(s => s.Value).ToList();



            foreach (var item in sortedlist)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
