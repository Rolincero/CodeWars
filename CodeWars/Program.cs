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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            Console.WriteLine(Function_that_does_arithmetic.Arithmetic(a, b, op));
        }
    }
}
