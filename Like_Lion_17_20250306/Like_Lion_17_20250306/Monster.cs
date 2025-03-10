using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_17_20250306
{
    class Monster
    {
        public Info m_tMonster;

        public void SetDamage(int iAttack) { m_tMonster.iHp -= iAttack; }
        public void SetMonster(Info tMonster) { m_tMonster = tMonster; }
        public Info GetMonster() { return m_tMonster; }
        public void Render()
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"몬스터 이름 : {m_tMonster.strName}");
            Console.WriteLine($"체력 : {m_tMonster.iHp} \t공격력 : {m_tMonster.iAttack}");


        }

        public void Info()
        {

        }
        ~Monster() { }
    }
}
