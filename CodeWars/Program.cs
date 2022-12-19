using CodeWars.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Program
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(Find_next_perfect_square.FindNextSquare(input));
        }
    }
}
