using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Methods
{
    internal class String_ends_with
    {
        /*
         * Complete the solution so that it returns true if the first argument(string)
         * passed in ends with the 2nd argument (also a string).
         */

        public static bool Solution(string str, string ending)
        {
            if (str.EndsWith(ending)) return true;
            else return false;
        }
    }
}
