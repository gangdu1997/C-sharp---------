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
            //int score = 99;
            //bool res = score >= 50;//在这里bool运算符，就是 判断 score 是否大于等于50，满足就是 true,不满足就是false.
            bool var1 = true;
            bool var2 = false;
            bool res1 = !var1;//取反操作
            bool res2 = var1 & var2;//var1 and var2,当都为 true 时，就为true;
            bool res3 = var1 | var2;//  var1 or var2, 当 至少有一个 为 true 时，就为true.
            bool res4 = var1 ^ var2;// 逻辑异或 当且仅当 有一个 为 true 时，为true。否则 全为 false.
            bool res5 = var1 && var2;// && 而且  与 & 一样
            bool res6 = var1 || var2;// || 或 与 | 一样
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine(res6);
            Console.ReadKey();
        }
    }
}
