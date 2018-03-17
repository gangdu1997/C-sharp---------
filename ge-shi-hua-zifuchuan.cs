using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp格式化字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("两个数相加{0}+{1}={2}", 3, 34, 34);
        }
    }
}
//当使用Write和WriteLine 方法进行输出时，可以对字符串进行格式化输出，
//Console.WriteLine("两个数相加{0}+{1}={2}", 3, 34, 34);
//Console.WriteLine("格式字符串，含替代标记{}",替换值0，替换值1，替换值2，......);
