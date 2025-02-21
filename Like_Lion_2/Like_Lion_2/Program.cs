using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Like_Lion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string consoleStr = "";
            for(int i = 0; i<10; i++)
            {
                consoleStr = "";
                for(int j = 0; j < 10; j++)
                {
                    if (i >= j)
                    {
                        consoleStr += "■";
                    }
                    else
                    {
                        consoleStr += "□";
                    }
                }
                Console.WriteLine(consoleStr);
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.WriteLine("텍스트 엘든링");

            Console.WriteLine("");
            Console.WriteLine("스토리 1");
            /*Console.WriteLine("□□□□□□□□□□");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("■□□□□□□□□□");*/

        }
    }
}
