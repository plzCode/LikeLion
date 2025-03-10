using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_17_20250306
{
    class Player
    {
        public Info m_tInfo;

        public void SelectJob()
        {
            m_tInfo = new Info();

            Console.WriteLine("직업을 선택하세요 (1.기사 2.마법사 3.도둑) : ");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "기사";
                    m_tInfo.iHp = 100;
                    m_tInfo.iAttack = 10;
                    break;
                case 2:
                    m_tInfo.strName = "akqjqtk";
                    m_tInfo.iHp = 90;
                    m_tInfo.iAttack = 15;
                    break;
                case 3:
                    m_tInfo.strName = "도둑";
                    m_tInfo.iHp = 85;
                    m_tInfo.iAttack = 13;
                    break;
            }

        }

        public void Render()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("직업 이름 : " + m_tInfo.strName);
            Console.WriteLine($"체력 : {m_tInfo.iHp} \t 공격력: {m_tInfo.iAttack}");

        }

        public void SetDamage(int iAttack) { m_tInfo.iHp -= iAttack; }
        public Info GetInfo() { return m_tInfo; }
        public void SetHp(int iHp) { m_tInfo.iHp = iHp; }


        public Player()
        {

        }
        ~Player() { }//소멸자
    }
}
