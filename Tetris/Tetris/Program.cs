using System;
using System.Threading;

class Tetris
{
    static int width = 10;
    static int height = 20;
    static int[,] board = new int[height, width];
    static int blockX = width / 2, blockY = 0;
    static bool gameOver = false;
    static int[,] currentBlock;
    static int blockSize;

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
        GenerateNewBlock();
        Thread inputThread = new Thread(InputHandler);
        inputThread.Start();
        

        while (!gameOver)
        {
            DrawBoard();
            MoveBlockDown();
            Thread.Sleep(500);
        }
        Console.Clear();
        Console.WriteLine("Game Over!");
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

    static void GenerateNewBlock()
    {
        currentBlock = blocks[random.Next(blocks.Length)];

        try
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
        }
            blockX = width / 2 - blockSize / 2;
        blockY = 0;
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
                if (currentBlock[y, x] == 1)
                {
                    int boardX = blockX + x;
                    int boardY = blockY + y;
                    if (boardX < 0 || boardX >= width || boardY >= height || board[boardY, boardX] == 1)
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
                if (currentBlock[y, x] == 1)
                {
                    board[blockY + y, blockX + x] = 1;
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
    }

    static void DrawBoard()
    {
        Console.Clear();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                bool isBlock = false;
                for (int by = 0; by < currentBlock.GetLength(0); by++)
                {
                    for (int bx = 0; bx < currentBlock.GetLength(1); bx++)
                    {
                        if (currentBlock[by, bx] == 1 && blockY + by == y && blockX + bx == x)
                        {
                            Console.Write("■");
                            isBlock = true;
                        }
                    }
                }
                if (!isBlock)
                    Console.Write(board[y, x] == 1 ? "■" : "□");
            }
            Console.WriteLine();
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

        return rotated;
    }
}
