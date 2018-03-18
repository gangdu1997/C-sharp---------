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
            bool var = false;
            if(var)
                Console.WriteLine("---------");
            Console.WriteLine("if语句后边的语句");

            if (34 <= 40)
                Console.WriteLine("---------");
            Console.WriteLine("if语句后边的语句");
            if (var == false)
                Console.WriteLine("---------");
            Console.WriteLine("if语句后边的语句");
            Console.ReadKey();
        }
    }
}
