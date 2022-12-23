using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Methods
{
    internal class Find_the_odd_int
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int firstMin = numbers.Min();
            int removal = Array.IndexOf(numbers, numbers.Min());
            var tmp = new List<int>(numbers);
            tmp.RemoveAt(removal);
            var updNumbers = tmp.ToArray();
            return firstMin + updNumbers.Min();
        }
    }
}
