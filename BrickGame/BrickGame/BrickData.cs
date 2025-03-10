using BrickGame;
using System.Collections.Generic;
using System;

public class BrickData
{
    public List<Brick> Bricks { get; set; } = new List<Brick>();

    public List<Brick> GetBricks() => Bricks;

    public void InitializeBricks()
    {
        int startX = 10; // 시작 X 위치
        int startY = 2;  // 시작 Y 위치
        int rowCount = 5; // 행 개수
        int colCount = 10; // 열 개수
        int brickWidth = 6; // 벽돌 간격
        int brickHeight = 1;

        for (int row = 0; row < rowCount; row++)
        {
            for (int col = 0; col < colCount; col++)
            {
                int x = startX + col * brickWidth;
                int y = startY + row * brickHeight;
                Bricks.Add(new Brick(x, y));
            }
        }
    }

    // 벽돌 화면에 그리기
    public void Render()
    {
        foreach (var brick in Bricks)
        {
            if (!brick.IsDestroyed)
            {
                Program.gotoxy(brick.X, brick.Y);
                Console.Write("■"); // 벽돌 모양 출력
            }
            else
            {
                Console.ReadLine();
            }
        }
    }

    // 충돌 체크
    public bool CheckCollision(int ballX, int ballY)
    {
        foreach (var brick in Bricks)
        {
            if (!brick.IsDestroyed && ballX >= brick.X && ballX < brick.X + brick.Width &&
                ballY == brick.Y)
            {
                brick.Destroy();
                return true;
            }
        }
        return false;
    }

    public void DestroyBrick(int x, int y)
    {
        foreach (var brick in Bricks)
        {
            if (brick.X == x && brick.Y == y)  // 해당 좌표의 벽돌 찾기
            {
                brick.Destroy();  // 실제 리스트에 있는 객체 수정
                return;
            }
        }
    }
    public void Progress()
    {
        // 삭제할 벽돌 찾기
        Bricks.RemoveAll(brick => brick.IsDestroyed);
    }
}