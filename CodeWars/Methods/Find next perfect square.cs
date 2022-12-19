using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Methods
{
    internal class Find_next_perfect_square
    {
        // Ищет следующий идеальный квадрат (
        public static long FindNextSquare(long num)
        {
            decimal sqrt = (decimal)Math.Sqrt(num);
            if (num % sqrt == 0)
            {
                long idealSqrt = (long)(int)Math.Sqrt(num) + 1;
                return idealSqrt;
            }
            else return -1;
        }
    }
}
