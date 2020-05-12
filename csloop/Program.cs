using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;
            while(start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count + "만큼 반복함");

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            /*int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                Thread.Sleep(100);
                x++;
            }*/
            bool state = true;
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
            }
            Console.WriteLine();

            // 실습문제 02
            int[] array02 = new int[10];

            foreach(var item in array02)
            {
                Console.WriteLine(item);
            }

            // 실습문제 03
            int[] array03_1 = new int[20];
            int[] array03_2 = new int[3] { 1, 2, 3 };
            // int[] array03_3 = int[] { 1,2,3};
            int[] array03_4 = { 1, 2, 3 };

            // 실습문제 04
            for(int i = 0; i < 20; i = i + 2)
            {
                Console.Write("출력");
            }
            Console.WriteLine();
            // 실습문제 05
            int _i = 0;
            while (_i < 10)
            {
                Console.Write("출력");
                _i++;
            }
        }
    }
}
