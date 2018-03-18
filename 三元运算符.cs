using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = Console.ReadLine();
            int sco = Convert.ToInt32(score);
            string resSco = sco >= 60 ? "成绩及格" : "成绩不及格";
            Console.WriteLine(resSco);
            Console.ReadKey();
        }
    }
}
