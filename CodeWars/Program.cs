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
            string str = Console.ReadLine();
            string ending = Console.ReadLine();
            Console.WriteLine(String_ends_with.Solution(str, ending));
        }
    }
}
