using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Methods
{
    internal class OddOrEven_in_array
    {
        public static string OddOrEven(int[] array)
        {
            if (array.Sum() % 2 == 0) return "even";
            else return "odd";
        }
    }
}
