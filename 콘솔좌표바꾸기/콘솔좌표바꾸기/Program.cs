using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표바꾸기
{
    class Program
    {
        static void Main(string[] args)
        {
            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);
            //콘솔 버퍼 크기 설정(스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);
            //콘솔 커서 숨기기
            Console.CursorVisible = false;
            /*
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("대장장이키우기");
            Console.WriteLine("콘솔 크기 변경");
            Console.ReadLine();
            */

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────┐");
            for(int i = 0; i<15; i++)
            {
                Console.WriteLine("│                                                                             │");
            }
            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
            Console.ReadLine();
            for(int i = 0; i<60; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(i, 10);
                Console.Write("◎");
                Thread.Sleep(100);
                
            }
        }
    }
}
