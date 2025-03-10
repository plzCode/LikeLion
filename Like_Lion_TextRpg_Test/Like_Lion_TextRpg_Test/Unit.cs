using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRpg_Test
{
    class Unit
    {
        public string name;
        public int max_health;
        public int health;
        public int damage;
        public int defense;
        public Unit() { }
        public Unit(string name, int max_health, int damage, int defense)
        {
            this.name = name;
            this.max_health = max_health;
            this.damage = damage;
            this.defense = defense;
            health = this.max_health;
        }

        public void TakeDamaged(Unit unit, Unit target)
        {
            int damage = Math.Max(target.damage - unit.damage, 1);
            target.health -= damage;
            if(target.health<= 0)
            {
                target.health = 0;
                Die();

            }
            Console.WriteLine($"{unit.name}의 공격 {damage}의 대미지, {target.name}은 체력이 {target.health}남았다.");


        }

        public void Die()
        {
            Console.WriteLine("사망");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"공격력 : {damage}");
            Console.WriteLine($"체력 : {health} / {max_health}");
            Console.WriteLine($"방어력 : {defense}");
        }
    }
}
