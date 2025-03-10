using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRPG
{
    class Monster:Unit
    {

        public Monster() { }
        public Monster(string name, int max_Hp, int hp, int max_Mp, int mp, int tough, Tolerance tolerance, Reducation reducation)
        {
            this.name = name;
            this.max_Hp = max_Hp;
            this.hp = hp;
            this.max_Mp = max_Mp;
            this.mp = mp;
            this.tough = tough;
            this.stamina = 0;

            this.tolerance = tolerance;
            this.reducation = reducation;
        }

        public void Show_Monster_Info()
        {
            Console.WriteLine($"{name}");
            Console.WriteLine($"{hp}/{max_Hp}");
        }
    }
}
