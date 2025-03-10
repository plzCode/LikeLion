using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Tetris
{
    static int width = 10;
    static int height = 25;
    static int[,] board = new int[height, width];
    static int blockX = width / 2, blockY = 0;
    static bool gameOver = false;
    static int[,] currentBlock;
    static int[,] nextBlock;
    static int blockSize;
    static int score = 0;


    static int[][,] blocks = new int[][,]
    {
        new int[,] { { 1, 1 }, { 1, 1 } }, // ㅁ블럭
        new int[,] { { 1, 1, 1 }, { 0, 1, 0 } }, //ㅜ 블럭
        new int[,] { { 1, 1, 0 }, { 0, 1, 1 } }, // Z 블럭
        new int[,] { { 0, 1, 1 }, { 1, 1, 0 } }, // S 블럭
        new int[,] { { 1, 0, 0 }, { 1, 1, 1 } }, // L 블럭
        new int[,] { { 0, 0, 1 }, { 1, 1, 1 } }, // J 블럭
        new int[,] { { 1, 1, 1, 1 } } // 일자블럭
    };

    static Random random = new Random();

    static void Main()
    {

        Console.CursorVisible = false;
        nextBlock = blocks[random.Next(blocks.Length)];
        GenerateNewBlock();
        Thread inputThread = new Thread(InputHandler);
        inputThread.Start();
        

        while (!gameOver)
        {
            DrawBoard();
            MoveBlockDown();
            DisplayScore();
            Thread.Sleep(400);
        }
        Console.Clear();
        Console.WriteLine("Game Over!");
    }

    static void DisplayScore()
    {
        Console.SetCursorPosition(22, 0);
        Console.WriteLine($"Score : {score}");
    }

    static void InputHandler()
    {
        while (!gameOver)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.LeftArrow) MoveBlock(-1);
                if (key == ConsoleKey.RightArrow) MoveBlock(1);
                if (key == ConsoleKey.DownArrow) MoveBlockDown();
                if (key == ConsoleKey.UpArrow) DropBlock();
                if (key == ConsoleKey.R) currentBlock = RotateBlock(currentBlock);
            }
        }
    }

    static void GenerateItem()
    {
        int itemProbability = random.Next(0, 100);
        List<(int, int)> itemPos = new List<(int, int)>();

        if (itemProbability < 50)
        {
            for (int i = 0; i < currentBlock.GetLength(0); i++)
            {
                for (int j = 0; j < currentBlock.GetLength(1); j++)
                {
                    if (currentBlock[i, j] == 1)
                    {

                        itemPos.Add((i, j));
                    }
                }
            }

            if(itemPos.Count > 0)
            {
                var (x, y) = itemPos[random.Next(0, itemPos.Count)];
                currentBlock[x, y] = 3;
            }

        }
    }

    static void GenerateNewBlock()
    {
        int[,] selectedBlock = blocks[random.Next(blocks.Length)];

        /*try
        {
            if(currentBlock.GetLength(0) > currentBlock.GetLength(1))
            {
                blockSize = currentBlock.GetLength(0);
            }
            else
            {
                blockSize = currentBlock.GetLength(1);
            }
        }
        catch
        {
            blockSize = currentBlock.GetLength(0);
        }*/
        /*blockSize = Math.Max(currentBlock.GetLength(0), currentBlock.GetLength(1));

        blockX = width / 2 - blockSize / 2;
        blockY = 0;

        currentBlock = new int[selectedBlock.GetLength(0), selectedBlock.GetLength(1)];
        Array.Copy(selectedBlock, currentBlock, selectedBlock.Length);

        GenerateItem();

        nextBlock = blocks[random.Next(blocks.Length)];

        if (!CanPlaceBlock())
        {
            gameOver = true;
        }*/

        currentBlock = new int[nextBlock.GetLength(0), nextBlock.GetLength(1)];
        Array.Copy(nextBlock, currentBlock, nextBlock.Length);

        nextBlock = new int[selectedBlock.GetLength(0), selectedBlock.GetLength(1)];
        Array.Copy(selectedBlock, nextBlock, selectedBlock.Length);

        blockSize = Math.Max(currentBlock.GetLength(0), currentBlock.GetLength(1));
        blockX = width / 2 - blockSize / 2;
        blockY = 0;

        GenerateItem();

        if (!CanPlaceBlock())
        {
            gameOver = true;
        }
    }

    static bool CanPlaceBlock()
    {
        for (int y = 0; y < currentBlock.GetLength(0); y++)
        {
            for (int x = 0; x < currentBlock.GetLength(1); x++)
            {
                if (currentBlock[y, x] == 1 || currentBlock[y,x] == 3)
                {
                    int boardX = blockX + x;
                    int boardY = blockY + y;
                    if (boardX < 0 || boardX >= width || boardY >= height || board[boardY, boardX] == 1 || board[boardY,boardX] == 3)
                        return false;
                }
            }
        }
        return true;
    }

    static void MoveBlock(int direction)
    {
        blockX += direction;
        if (!CanPlaceBlock()) blockX -= direction;
    }

    static void MoveBlockDown()
    {
        blockY++;
        if (!CanPlaceBlock())
        {
            blockY--;
            LockBlock();
        }
    }

    static void DropBlock()
    {
        while (CanPlaceBlock())
        {
            blockY++;
        }
        blockY--;
        LockBlock();
    }

    static void LockBlock()
    {
        for (int y = 0; y < currentBlock.GetLength(0); y++)
        {
            for (int x = 0; x < currentBlock.GetLength(1); x++)
            {
                if (currentBlock[y, x] == 1 || currentBlock[y,x] == 3)
                {

                    board[blockY + y, blockX + x] = currentBlock[y,x];
                }
            }
        }
        ClearFullRows();
        GenerateNewBlock();
    }

    static void ClearFullRows()
    {
        for (int y = height - 1; y >= 0; y--)
        {
            bool isFull = true;
            for (int x = 0; x < width; x++)
            {
                if (board[y, x] == 0)
                {
                    isFull = false;
                    break;
                }
            }
            if (isFull)
            {
                RemoveRow(y);
                y++;
            }
        }
    }

    static void RemoveRow(int row)
    {
        /*bool extraRemove = false;

        // 3이 있는지 확인
        for (int x = 0; x < width; x++)
        {
            if (board[row, x] == 3)
            {
                extraRemove = true; //  "3"이 포함된 줄이라면 위아래 한 줄 더 삭제
                break;
            }
        }
        for (int y = row; y > 0; y--)
        {
            for (int x = 0; x < width; x++)
            {
                board[y, x] = board[y - 1, x];
            }
        }
        for (int x = 0; x < width; x++)
        {
            board[0, x] = 0;
        }

        if (extraRemove)
        {
            if (row + 1 < height) RemoveRow(row + 1); // 아래 한 줄 삭제
            if (row - 1 >= 0) RemoveRow(row - 1); // 위 한 줄 삭제
        }
        score += 100;*/
        HashSet<int> rowsToRemove = new HashSet<int>(); // 중복 방지를 위한 HashSet
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(row);
        rowsToRemove.Add(row);

        while (queue.Count > 0)
        {
            int queue_row = queue.Dequeue();

            // 현재 행에 3이 포함되어 있으면 위아래 추가 삭제
            bool extraRemove = false;
            for (int x = 0; x < width; x++)
            {
                if (board[queue_row, x] == 3)
                {
                    extraRemove = true;
                    break;
                }
            }

            if (extraRemove)
            {
                if (queue_row + 1 < height && !rowsToRemove.Contains(queue_row + 1))
                {
                    queue.Enqueue(queue_row + 1);
                    rowsToRemove.Add(queue_row + 1);
                }
                if (queue_row - 1 >= 0 && !rowsToRemove.Contains(queue_row - 1))
                {
                    queue.Enqueue(queue_row - 1);
                    rowsToRemove.Add(queue_row - 1);
                }
            }
        }

        // **위쪽 줄부터 순서대로 삭제 (행이 내려오는 문제 방지)**
        List<int> sortedRows = rowsToRemove.ToList();
        sortedRows.Sort();

        foreach (int r in sortedRows)
        {
            for (int y = r; y > 0; y--)
            {
                for (int x = 0; x < width; x++)
                {
                    board[y, x] = board[y - 1, x];
                }
            }
            for (int x = 0; x < width; x++)
            {
                board[0, x] = 0; // 최상단은 빈 공간으로 초기화
            }
        }

        score += rowsToRemove.Count * 100; // 지운 줄 개수에 따라 점수 추가
    }

    static void DrawBoard()
    {
        //Console.Clear();
        Console.SetCursorPosition(0, 0);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                bool isBlock = false;
                for (int by = 0; by < currentBlock.GetLength(0); by++)
                {
                    for (int bx = 0; bx < currentBlock.GetLength(1); bx++)
                    {
                        if ((currentBlock[by, bx] == 1 || currentBlock[by, bx] == 3) && blockY + by == y && blockX + bx == x)
                        {
                            Console.Write(currentBlock[by, bx] == 3 ? "▣" : "■"); // 3이면 ▣ 출력
                            isBlock = true;
                        }
                    }
                }

                if (!isBlock)
                {
                    /*if (board[y, x] == 1)
                        Console.Write("■");
                    else if (board[y, x] == 3)
                        Console.Write("▣");
                    else
                        Console.Write("□");*/
                    Console.Write(board[y, x] == 1 ? "■" : board[y, x] == 0 ? "□" : "▣");
                }
            }
            Console.WriteLine();
        }


        int nextBlockPosX = 22; // 다음 블록 출력 위치 X
        int nextBlockPosY = 2;  // 다음 블록 출력 위치 Y

        for (int y = 0; y < 4; y++) // 최대 블록 높이(4칸)를 기준으로 지움
        {
            Console.SetCursorPosition(nextBlockPosX, nextBlockPosY + y + 1);
            Console.Write(new string(' ', 10)); // 10칸을 공백으로 채워서 지우기
        }

        Console.SetCursorPosition(nextBlockPosX, nextBlockPosY);
        Console.Write("다음 블록:");

        // 블록 출력
        for (int y = 0; y < nextBlock.GetLength(0); y++)
        {
            Console.SetCursorPosition(nextBlockPosX, nextBlockPosY + y + 1); // 줄마다 커서 위치 지정
            for (int x = 0; x < nextBlock.GetLength(1); x++)
            {
                Console.Write(nextBlock[y, x] == 1 ? "■" : "  ");
            }
        }
    }

    static int[,] RotateBlock(int[,] block)
    {
        int rows = block.GetLength(0);
        int cols = block.GetLength(1);
        int[,] rotated = new int[cols, rows]; // 새 배열 (행, 열 크기 바뀜)

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rotated[j, rows - 1 - i] = block[i, j];
            }
        }

        // 회전 후 블록이 보드 안에 있는지 확인
        if (CanPlaceAfterRotation(rotated))
        {
            return rotated;
        }

        // 벽 밀기(Wall Kick) 시도: 왼쪽으로 한 칸
        blockX--;
        if (CanPlaceAfterRotation(rotated))
        {
            return rotated;
        }
        blockX++; // 원상 복구

        // 벽 밀기(Wall Kick) 시도: 오른쪽으로 한 칸
        blockX++;
        if (CanPlaceAfterRotation(rotated))
        {
            return rotated;
        }
        blockX--; // 원상 복구

        // 만약 전부 실패하면 원래 블록 유지
        return block;
    }
    // 회전 후 블록이 보드 안에 있는지 확인하는 함수
    static bool CanPlaceAfterRotation(int[,] rotatedBlock)
    {
        for (int y = 0; y < rotatedBlock.GetLength(0); y++)
        {
            for (int x = 0; x < rotatedBlock.GetLength(1); x++)
            {
                if (rotatedBlock[y, x] == 1 || rotatedBlock[y, x] == 3)
                {
                    int boardX = blockX + x;
                    int boardY = blockY + y;

                    if (boardX < 0 || boardX >= width || boardY < 0 || boardY >= height)
                        return false;

                    if (board[boardY, boardX] == 1)
                        return false;
                }
            }
        }
        return true;
    }
}
