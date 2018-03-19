using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //这里是枚举类型的定义
    enum GameState
    {
        //默认 整型 存储
        Pause,//默认代表的是整数0；
        Failed,//默认代表的是整数1；
        Success,//默认整数2
        Start//默认整数3
        //也可以修改默认值，随着第一个值 Pause 而 ++1；
    }
    class Program
    {
        static void Main(string[] args)
        {
        //    //利用定义好的枚举类型 去声明变量
        //    GameState state = GameState.Start;
        //    if (state == GameState.Start)
        //    {
        //        Console.WriteLine("当前处于游戏开发状态");
        //    }
        //    Console.WriteLine(state);
            //////////////////
            //int state = 3;
            //if (state == 3)
            //{
            //    Console.WriteLine("当前处于游戏开始界面");
            //}
            GameState state = GameState.Start;
            int num = (int)state;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
