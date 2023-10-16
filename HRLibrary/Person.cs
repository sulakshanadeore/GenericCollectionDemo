using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Person : IEnumerator
    {
      public  int[] arr;
        public Person()
        {
            
        }
        public Person(int[] data)
        {
            arr = data;
        }

        int pos = -1;
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            //throw new NotImplementedException();
            pos++;
            return pos<arr.Length;

        }

        public void Reset()
        {
            //throw new NotImplementedException();
            pos=-1;
            Console.WriteLine( pos);
        }
    }
}
