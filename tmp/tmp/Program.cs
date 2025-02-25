using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //이모지 안깨지게하기

            Random rand = new Random();
            int hp = 500;
            int mp = 100;
            int skilLv = 1;
            int catchShoggoth = 0;
            int slaveShoggoth = 0;
            int deadShoggoth = 0;
            int input;
            bool isAlive = true;

            Console.SetWindowSize(80, 25);
            //Console.SetBufferSize(80, 25);
            
            Console.CursorVisible = false;


            //첫 로딩화면
            #region 첫 로딩화면
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                  Tekeli-li                                   ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 21);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 22);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 23);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 24);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region 스토리 시작

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, 20);
            Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.SetCursorPosition(0, 21);
            Console.Write("  태고의 시대.                                                                ");
            Console.SetCursorPosition(0, 22);
            Console.Write("  당신들은 올드 원이다.                                                       ");
            Console.SetCursorPosition(0, 23);
            Console.Write("  광대한 우주의 비밀을 쥐고, 창조와 파괴를 오락처럼 즐기던 존재.                 ");
            Console.SetCursorPosition(0, 24);
            Console.Write("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.ReadLine();
            #endregion
        }
    }
}
