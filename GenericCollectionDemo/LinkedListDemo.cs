using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    internal class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> lilist = new LinkedList<int>();
            lilist.AddFirst(1);
          LinkedListNode<int> nodeFor2 =lilist.AddAfter(lilist.First, 2);
            lilist.AddAfter(nodeFor2, 3);
            lilist.AddBefore(nodeFor2, 100);

            lilist.AddLast(20);
            foreach (var item in lilist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
