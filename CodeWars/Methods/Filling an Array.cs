using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Methods
{
    internal class Filling_an_Array
    {
       /* We want an array, but not just any old array, an array with contents!
        *
        *  Write a function that produces an array with the numbers 0 to N-1 in it.
        *
        *  For example, the following code will result in an array containing the numbers 0 to 4:
        */

        public static int[] Arr(int N)
        {
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            return array;
        }
    }
}
