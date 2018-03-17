using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            string name = "siki";

            Console.Write("名字：\t  \\  \"{0}\"\n hp：{1}",name,hp);//内部的引号 都加 \，\" 表示 普通字符。
            Console.ReadKey();
        }
    }
}
