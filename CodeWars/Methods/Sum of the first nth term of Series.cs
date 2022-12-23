using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Methods
{
    internal class Sum_of_the_first_nth_term_of_Series
    {
        public static string seriesSum(int n)
        { 
            decimal result = 1;
            if (n != 0)
            {
                for (decimal i = 0, m = 4; i < n - 1; i++)
                {
                    result += 1 / m;
                    m += 3;
                }
            }
            else return "0";
            string strresult = Math.Round(result, 2).ToString("#.##");
            return strresult;
        }
    }
}
