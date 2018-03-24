using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "www.taikr.com";
            for (int i = 0; i < str.Length;i ++ )
            {
                Console.WriteLine(str[i]);
            }
            //string res = str.ToLower();//把字符串转换成小写 并返回
            //string res = str.ToUpper();//把字符串转换成大写 并返回
            string res = str.Trim();//去掉前边和后边的 空白字符
            string res1 = str.TrimStart();//去掉前边的 空白字符
            string res2 = str.TrimEnd();//去掉后边的 空白字符
            Console.ReadKey();
        }
    }
}
