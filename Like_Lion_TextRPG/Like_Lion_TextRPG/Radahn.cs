using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRPG
{
    class Radahn:Monster
    {
        int[] max_HpList = { 9572, 12405, 13646, 14266, 14886, 16127, 16747, 17367 };
        Tolerance tolerance = new Tolerance(334.0f, 548.0f);
        Reducation reducation = new Reducation(10.0f, 10.0f);
        int tough = 200;
        

        public Radahn()
        {
            name = "Radahn";
            max_Hp = max_HpList[Game_Mannager.episode - 1];
            hp = max_Hp;
            max_Mp = 0;
            mp = max_Mp;
            tough = 200;
            tolerance = new Tolerance(334.0f, 548.0f);
            reducation = new Reducation(10.0f, 10.0f);

        }
    }
}
