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
            int exam = int.Parse(Console.ReadLine());
            int projects = int.Parse(Console.ReadLine());
            Console.WriteLine(Student_s_Final_Grade.FinalGrade(exam, projects));
        }
    }
}
