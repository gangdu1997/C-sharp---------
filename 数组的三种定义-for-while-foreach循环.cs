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
            //第一种 数组的初始化
            int[] scores = { 1, 2, 3, 4, 5, 6 };

            //第二种
            //int[] scores = new int[6];
            //int[] scores;
            //scores = new int[6];

            //第三种
            //int[] scores = new int[6] { 1, 2, 3, 4, 5, 6 };

            //scores.Length //得到数组的长度
            //for(int i = 0;i < scores.Length;i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //int i = 0;
            //while (i < scores.Length）
            //{
            //    Console.WriteLine(scores[i]);
            //    i++;
            //}
            foreach (int temp in scores)//foreach会依次取到数组中的值，然后赋值给temp，然后执行循环体 
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
