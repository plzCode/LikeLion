using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_5_20250226
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int[] numbers1 = { 1, 2, 3 }; //간단한 선언과 함께 초기화
            int[] numbers2 = new int[3]; //크기만 설정
            int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언*/

            /*string[] fruits = { "사과", "바나나", "오렌지" };

            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }*/

            /*int[][] scores = new int[][] {
                new int[] {0,0,0,0},
                new int[] {0,0,0,0},
                new int[] {0,0,0,0}
            };
            string[] subject = { "국어", "수학", "영어", "과학" };

            for(int i = 0; i<scores.GetLength(0); i++)
            {
                for(int j = 0; j<scores[i].GetLength(0); j++)
                {
                    Console.Write(subject[j] + " 점수를 입력해 : ");
                    scores[i][j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
            }

            for(int i = 0; i< scores.GetLength(0); i++)
            {
                int sum = 0;
                for(int j=0; j< scores[i].GetLength(0); j++)
                {
                    sum += scores[i][j];
                }
                float avg = (float)sum / subject.GetLength(0);
                Console.WriteLine("총점 : " + sum);
                Console.WriteLine("평균 : " + avg.ToString("F2"));
                Console.WriteLine("");
            }*/

            /*//1차원 배열
            int[] scores = new int[3];

            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 88;

            for(int i = 0; i<scores.Length; i++)
            {
                Console.WriteLine($"점수 {i + 1} : {scores[i]}");
            }*/

            /*double value = 3.14159265358979;

            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점 둘째자리 : {value:F2}");
            Console.WriteLine(String.Format("소수점 둘째자리 : {0:F2}", value));

            Console.WriteLine(value.ToString("N2"));*/

            /*int[,] matrix = new int[2, 3]
            {
                { 1,2,3 },
                { 4,5,6 }
            };

            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j<matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"{i}, {j} = {matrix[i, j]}");
                }
            }*/

            /*int[][] matrix = new int[2][];

            for(int i=0; i<matrix.GetLength(0); i++)
            {
                matrix[i] = new int[3];
            }          
            

            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j= 0; j<matrix[i].GetLength(0); j++)
                {
                    matrix[i][j] = j + (i);
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }*/

            /*//가변 배열
            Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 1, 2 };
            jaggedArray[2] = new int[] { 1 };
            
            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"배열 타입: {numbers.GetType()}");*/

            /*int[] iArray = new int[] { 0 };

            //셔플 / 스왑
            int a = 10;
            int b = 20;
            int tmp = 0;

            tmp = a;
            a = b;
            b = tmp;*/

            /*int[] iArray = new int[25];

            for(int i = 0; i<iArray.GetLength(0); i++)
            {
                iArray[i] = i + 1;
            }

            for(int i =0; i<5; i++)
            {
                for(int j = 0; j<5; j++)
                {
                    Console.Write($"{iArray[i*5 +j].ToString("D2")} ");
                }
                Console.WriteLine();
            }*/

            /*int[] iArray = new int[25];


            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }



            Random rand = new Random();
            //셔플
            for (int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;


                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;
            }

            int input = 0;

            int iCount = 0;
            int iBingo = 0;
            while (true)
            {
                Console.Clear();

                //빙고판
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (iArray[i * 5 + j] == 0)  //0일경우 체크
                        {
                            Console.Write("★ ");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("빙고 숫자 : " + iBingo);
                Console.WriteLine("숫자를 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;
                for (int i = 0; i < 25; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }


                //빙고 체크 로직
                //가로 체크
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (iArray[i * 5 + j] == 0)
                        {
                            ++iCount;
                        }

                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }

                //세로 체크
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i + 5 * j] == 0)
                        {
                            ++iCount;
                        }

                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }



                //대각선 오른쪽체크
                //00 01 02 03 04
                //05 06 07 08 09
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24

                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 4 + 4] == 0)
                    {
                        ++iCount;
                    }

                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;







                //대각선 왼쪽체크
                //00 01 02 03 04
                //05 06 07 08 09
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24
                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 6] == 0)
                    {
                        ++iCount;
                    }

                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;


                if (iBingo >= 5)
                {
                    Console.WriteLine("빙고 성공");
                    break;
                }
            }*/

            int[,] board = new int[5, 5];
            int boardX = board.GetLength(0);
            int boardY = board.GetLength(1);

            bool[,] marked = new bool[boardX, boardY];
            int[] numbers = new int[boardX * boardY];
            int bingoCount = 0;

            Random rand = new Random();

            for(int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            for(int i = 0; i<100; i++)
            {
                int a = rand.Next(boardX*boardY);
                int b = rand.Next(boardX * boardY);

                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }

            //2차원 배열로 변환
            int index = 0;
            for(int i=0; i<boardX; i++)
            {
                for(int j =0; j<boardY; j++)
                {
                    board[i, j] = numbers[index];
                    index++;
                }
            }

            while (bingoCount < 5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");


                for (int i = 0; i < boardX; i++)
                {
                    for (int j = 0; j < boardX; j++)
                    {
                        if (marked[i, j])
                            Console.Write("★ ");
                        else
                            Console.Write(board[i,j].ToString("D2") +" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25) : ");
                int number = 0;
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }

                bool found = false;
                for (int i = 0; i < boardX; i++)
                {
                    for (int j = 0; j < boardY; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true; //숫자를 X로 변경
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로체크
                for (int i = 0; i < boardX; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < boardY; j++)
                    {
                        if (!marked[i, j]) rowBingo = false;
                    }

                    if (rowBingo) bingoCount++;
                }


                //세로체크
                for (int j = 0; j < boardX; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < boardY; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) bingoCount++;
                }


                //대각선 체크 (왼쪽위 ->오른쪽 아래)
                bool diag1Bingo = true;
                for (int i = 0; i < boardY; i++)
                {
                    if (!marked[i, i])
                        diag1Bingo = false;
                }
                if (diag1Bingo)
                    bingoCount++;


                //대각선 오른쪽위 ->왼쪽아래
                bool diag2Bingo = true;
                for (int i = 0; i < boardY; i++)
                    if (!marked[i, 4 - i]) diag2Bingo = false;

                if (diag2Bingo) bingoCount++;

            }
            Console.WriteLine("빙고 5개 완성! 게임종료");
        }






    }
}

