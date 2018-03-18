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
            //从用户处接收 字符串
            string str1 = Console.ReadLine();
            //字符串 转换为 数字
            int num1 = Convert.ToInt32(str1);
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            int sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
