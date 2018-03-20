using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //我们可以把 结构体 当成，几个类型 组成了 一个 新的类型。
    //比如下边的这个就是使用了 3 个 float 类型的变量，来表示 一个坐标类型。
    // 结构 取值较多时，使用。
    struct Position
    {
        public float x;
        public float y;
        public float z;
    }

    // 枚举 属性 取值 有限时，使用。
    enum Direction
    {
        N,
        S,
        W,
        E
    }

    struct Path
    {
        public float distance;
        public Direction dir;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //通过三个float类型的变量来表示一个敌人的坐标
            float enemy1x = 34;
            float enemy1y = 1;
            float enemy1z = 34;
            //当使用 结构体 声明变量时， 相当于 使用 结构体中 所有的变量 去声明。
            Position enemy1Position;
            enemy1Position.x = 34;//可以通过 加上属性名来访问结构体中指定的变量。
            //使用结构体 让 程序 更清晰
            enemy1Position.y = 1;

            Path path1;
            path1.dir = Direction.E;
            path1.distance = 1000;


            Console.ReadKey();
        }
    }
}
