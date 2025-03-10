using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_My_Console_Game
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
            Console.SetBufferSize(80, 30);
            Map_Manager map_mg = new Map_Manager();
            Map_Generator map_gn = new Map_Generator(); 

            map_mg.Map_Init();

            map_mg.wall = map_gn.GenerateMap(map_mg.map.GetLength(0), map_mg.map.GetLength(1));

            while (true)
            {
                map_gn.PrintMap(map_mg.wall);
            }
            
            //map_mg.Draw_Map();
            
        }
    }

    class Map_Generator
    {
        static Random random = new Random();
        public int[,] GenerateMap(int width, int height)
        {
            int[,] map = new int[width, height];

            // 1. 테두리는 벽으로 설정
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i == 0 || j == 0 || i == width - 1 || j == height - 1)
                    {
                        map[i, j] = 1; // 테두리 벽
                    }
                    else
                    {
                        map[i, j] = 0; // 기본적으로 빈 공간
                    }
                }
            }

            // 2. 내부 벽 랜덤 배치 (30% 확률로 배치, 최소 2칸 간격 유지)
            for (int i = 2; i < width - 2; i += 2)
            {
                for (int j = 2; j < height - 2; j += 2)
                {
                    if (random.NextDouble() < 0.3) // 30% 확률로 벽 생성
                    {
                        map[i, j] = 1;

                        // 벽을 확장할 방향을 랜덤하게 선택 (상, 하, 좌, 우)
                        int dir = random.Next(4);
                        switch (dir)
                        {
                            case 0: if (j - 1 > 0) map[i, j - 1] = 1; break; // 위쪽 확장
                            case 1: if (j + 1 < height - 1) map[i, j + 1] = 1; break; // 아래쪽 확장
                            case 2: if (i - 1 > 0) map[i - 1, j] = 1; break; // 왼쪽 확장
                            case 3: if (i + 1 < width - 1) map[i + 1, j] = 1; break; // 오른쪽 확장
                        }
                    }
                }
            }

            // 3. 특정 위치(플레이어, 목표 지점)는 빈 공간 유지
            map[1, 1] = 0; // 플레이어 시작 지점
            map[width - 2, height - 2] = 0; // 목표 지점

            return map;
        }
        public void PrintMap(int[,] map)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            for (int j = 0; j < height; j++) // 출력할 때 X, Y 뒤집기
            {
                for (int i = 0; i < width; i++)
                {
                    try
                    {
                        Console.SetCursorPosition(i * 2, j);
                        Console.Write(map[i, j] == 1 ? "■" : " ");
                    }
                    catch
                    {
                        return;
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }


    class Flag
    {
        bool isFind = false;


    }
    
    class Map_Manager
    {
        public int[,] map;
        public int margin = 50; //여백

        public int[,] wall = 
            { 
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 0, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3 }
            };


        /*int[,] reversWall = */

        public void Map_Init()
        {
            //Console.SetBufferSize(300, 150);
            
            int x = Console.WindowWidth/2;
            int y = Console.WindowHeight/2;
            this.map = new int[x,y];

            for(int i=0; i<map.GetLength(0); i++)
            {
                for(int j = 0; j<map.GetLength(1); j++)
                {
                    map[i, j] = 0;                    
                }
            }

            
        }

        public void Draw_Map()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {


                    if (i < wall.GetLength(0) && j < wall.GetLength(1))
                    {
                        map[i, j] = wall[i, j];
                    }

                    /*if (i >= map.GetLength(0) - 1 || i <= 0)
                    {
                        map[i, j] = 1;
                    }
                    if (j >= map.GetLength(1) - 1 || j <= 0)
                    {
                        map[i, j] = 1;
                    }*/

                    if (map[i, j] == 0)
                    {
                        Console.SetCursorPosition(i * 2, j * 2);
                        Console.Write(".");
                    }
                    if (map[i, j] == 1)
                    {
                        Console.SetCursorPosition(i * 2, j * 2);
                        Console.Write("#");
                    }
                    if (map[i, j] == 3)
                    {
                        Console.SetCursorPosition(i * 2, j * 2);
                        Console.Write("!");
                    }

                    /*Console.SetCursorPosition(i*2, j*2);
                    Console.Write(j);*/

                }
            }
        }


    }
    
}
