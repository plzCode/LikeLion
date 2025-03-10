using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_16_20250306
{
    public abstract class Character
    {
        public string name { get; set; }
        public int health { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }

        protected Character(string name, int health, int attack, int defense)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
        }

        //추상 메서드 : 모든 캐릭터가 구현해야할 기본 공격
        public abstract void BasicAttack(Character target);

        public abstract void SpecialAttack(Character target);

        public void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - defense);
            health = Math.Max(0, health - actualDamage);

            if(health <= 0)
            {
                Console.WriteLine("사망");
            }
            else
            {
                Console.WriteLine($"{name}이(가) {actualDamage}의 피해를 입었습니다. 남은체력 : {health}");
            }
        }
        
    }
}
