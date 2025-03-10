using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRpg_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMannager gm = new GameMannager();

            gm.Init();
            gm.Progress();
        }
    }
}
