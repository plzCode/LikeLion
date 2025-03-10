using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class GameManager
    {
        Ball m_pBall = null;
        Bar m_pBar = null;
        BrickData m_Brick = null;
        public void Initialize()
        {
            if(m_pBall == null)
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }

            //바
            if(m_pBar == null)
            {
                m_pBar = new Bar();
                m_pBar.Initialize();

            }

            //벽돌
            if(m_Brick == null)
            {
                m_Brick = new BrickData();
                m_Brick.InitializeBricks();
            }

            //볼에서 바와 벽돌을 사용해야할거같다.
            m_pBall.SetBar(m_pBar);
            m_pBall.SetBrick(m_Brick);


        }

        public void Progress()
        {
            m_pBall.Progress();
            m_pBar.Progress(ref m_pBall);
            m_Brick.Progress();

        }

        public void Render()
        {
            Console.Clear();
            m_pBall.Render();
            m_pBar.Render();
            m_Brick.Render(); 
        }

        public void Release()
        {
            m_pBall.Release();
            m_pBar.Release();
        }

    }
}
