using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRPG
{
    class Unit
    {
        public string name;
        public int max_Hp;
        public int hp;
        public int max_Mp;
        public int mp;
        public int stamina;

        public int tough; //강인도

        public Tolerance tolerance;
        public Reducation reducation;



        public void SetStats(int max_Hp, int hp, int max_Mp, int mp, int stamina, int tough, Tolerance tolerance, Reducation reducation)
        {
            this.max_Hp = max_Hp;
            this.hp = hp;
            this.max_Mp = max_Mp;
            this.mp = this.max_Mp;
            this.stamina = stamina;
            this.tough = tough;
            this.tolerance = tolerance;
            this.reducation = reducation;
        }

        public void Attack(Unit target, int damage)
        {
            target.hp = target.hp - damage; //경감률 같은것도 포함해야함
        }


    }

    public class Tolerance
    {
        public float posion;
        public float bleeding;

        public Tolerance(float posion, float bleeding)
        {
            this.posion = posion;
            this.bleeding = bleeding;
        }
    }

    public class Reducation
    {
        public float nomarl;
        public float cut;

        public Reducation(float nomarl, float cut)
        {
            this.nomarl = nomarl;
            this.cut = cut;
        }
    }

    
}
