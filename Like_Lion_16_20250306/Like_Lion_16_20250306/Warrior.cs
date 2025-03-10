using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_16_20250306
{
    class Warrior : Character
    {
        public Warrior(string name, int health, int attack, int defense) : base(name, 100, 15, 10)
        {
        }

        public override void BasicAttack(Character target)
        {
            Console.WriteLine($"{name}이 {target.name}에게 기본 공격을 합니다.");
            target.TakeDamage(attack);
        }

        public override void SpecialAttack(Character target)
        {
            Console.WriteLine($"{name}이 {target.name}에게 휠 윈드를 사용합니다.");
            target.TakeDamage(attack * 2);
        }
    }
}
