using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRpg_Test
{
    class Monster:Unit
    {
        public Monster(string name, int damage, int max_health, int defense)
        {
            this.name = name;
            this.damage = damage;
            this.max_health = max_health;
            this.health = this.max_health;
            this.defense = defense;
        }
    }
}
