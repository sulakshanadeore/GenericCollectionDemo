using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    internal class LambdaDemo
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 8, 10, 9 };
            //List<int> arr2=(List<int>)arr1.Where(a => a % 2 == 0);
            IEnumerable<int> arr2 = arr1.Where(a1 => a1 % 2 == 0);
// => goesto/lamda/lambda expression/condition follows                                                    





            //Where specifies  a condition and that condition evaluates to true or false, so the func lambda is having bool predicate, but after the condtion evaluation completes it expects a list as per the condition evaluated.



        }
    }
}
