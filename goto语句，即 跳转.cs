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
            int myInteger = 5;
            goto mylabel;//goto语句用来控制程序跳转到某个位置
            myInteger ++;
        mylabel: Console.WriteLine(myInteger);
            Console.ReadKey();
        }
    }
}
