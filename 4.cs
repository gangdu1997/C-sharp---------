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
            //当在字符串 前边加上 @ 时，
            //1 .转义字符 \ 不能被识别，两个双引号，能被识别 成为一个双引号。
            //2 .我们就可以吧 一行字符串定义在多行。 
            string str1 = @"I'm a good man ""
you are a bad ";
            Console.WriteLine(str1);
            string str2 = @"I'm a good man \n,""you are a bad ";
            string str3 = "I'm a good man ,you are a bad ";
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            // 使用@字符时，路径 不用打两个 \\.
            string path1 = "C:\\XXX\\XX\\X";
            string path2 = @"C:\XXX\XX\X";
            Console.WriteLine(path1);
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
