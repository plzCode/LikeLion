using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_16_20250306
{
    class Mage : Character
    {
        public Mage(string name, int health, int attack, int defense) : base(name, 80, 20, 5)
        {
        }

        public override void BasicAttack(Character target)
        {
            Console.WriteLine($"{name}이 {target.name}에게 마법 구체를 던집니다.");
            target.TakeDamage(attack);
        }

        public override void SpecialAttack(Character target)
        {
            Console.WriteLine($"{name}이 {target.name}에게 화염 폭발을 시전합니다.");
            target.TakeDamage(attack * 2);
        }
    }
}
