using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Brick
    {
        public int X { get; set; } // 벽돌의 X 좌표
        public int Y { get; set; } // 벽돌의 Y 좌표
        public int Width { get; set; } = 5; // 벽돌의 기본 너비
        public int Height { get; set; } = 1; // 벽돌의 기본 높이
        public bool IsDestroyed { get; set; } = false; // 벽돌이 깨졌는지 여부

        public Brick(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Destroy()
        {
            IsDestroyed = true;
        }


    }
}
