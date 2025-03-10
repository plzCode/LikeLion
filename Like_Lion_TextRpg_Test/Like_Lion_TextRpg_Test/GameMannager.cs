using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRpg_Test
{
    class GameMannager
    {
        public Player player = null;
        public Field field = null;
        public void Init()
        {
            player = new Player();
            player.Choose_Class();
            Console.ReadLine();
            Console.Clear();
            field = new Field();
            Console.WriteLine();
            field.Choose_Field();
        }

        public void Progress()
        {
            Console.Clear();
            if (player == null)
            {
                player.Choose_Class();
            }
            if(field == null)
            {
                field.Choose_Field();
            }

            while (true)
            {
                if(field.map_name != null)
                {
                    Console.Clear();
                    player.ShowInfo();
                    Fight();
                }
            }
        }

        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                for(int i = 0; i<field.boss.Count; i++)
                {
                    Console.Clear();
                    player.ShowInfo();
                    Console.WriteLine("\n============\n");
                    field.boss[i].ShowInfo();
                    Console.WriteLine("\n============\n");

                    Console.WriteLine("1.공격 2.도망 : ");
                    iInput = int.Parse(Console.ReadLine());

                    if (iInput == 1)
                    {
                        player.TakeDamaged(player, field.boss[i]);
                        field.boss[i].TakeDamaged(field.boss[i], player);

                        if (player.health <= 0)
                        {
                            player.health = player.max_health;
                            break;
                        }

                    }

                    if (iInput == 2 || field.boss[i].health <= 0)
                    {
                        field.boss[i] = null;
                        return;//while문 종료
                    }
                }
                
            }

        }
    }
}
