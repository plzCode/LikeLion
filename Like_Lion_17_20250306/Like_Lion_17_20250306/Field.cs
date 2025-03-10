using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_17_20250306
{
    class Field
    {
        Player m_pPlayer = null;
        Monster m_pMonster = null;
        public void SetPlayer(ref Player player)
        {
            m_pPlayer = player;
        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if(iInput == 4)
                {
                    break;
                }

                if(iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }

        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if(m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }

                }

                if (iInput == 2 || m_pMonster.GetMonster().iHp <=0)
                {
                    m_pMonster = null;
                    break;//while문 종료
                }
            }

        }

        public void CreateMonster(int iInput)
        {
            switch (iInput)
            {
                case 1:
                    Create("초보몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out m_pMonster);
                    break;                    
                case 3:
                    Create("고수몹", 90, 9, out m_pMonster);
                    break;
            }
        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            Info tMonster = new Info();

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster);
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("5. 전단계");
            Console.WriteLine("============");
            Console.WriteLine("맵을 선택하세요");
        }

        public Field()
        {

        }
        ~Field() { }
    }



}
