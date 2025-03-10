using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRpg_Test
{
    class Player:Unit
    {
        public void Choose_Class()
        {
            Console.WriteLine("===직업 선택===");
            Console.WriteLine("기사");
            Console.WriteLine("공격력 - 10");
            Console.WriteLine("체력 - 100");
            Console.WriteLine("방어력 - 30");
            Console.WriteLine();

            Console.WriteLine("마법사");
            Console.WriteLine("공격력 - 30");
            Console.WriteLine("체력 - 70");
            Console.WriteLine("방어력 - 10");
            Console.WriteLine();

            
            Console.WriteLine("도적");
            Console.WriteLine("공격력 - 17");
            Console.WriteLine("체력 - 90");
            Console.WriteLine("방어력 - 20"); 
            Console.WriteLine();

            Console.Write("직업을 선택하세요 (1.기사 2.마법사 3.도적) : ");
            int user_Class = int.Parse(Console.ReadLine());

            switch (user_Class) 
            {
                case 1:
                    damage = 10;
                    max_health = 100;
                    health = max_health;
                    defense = 30;
                    break;
                case 2:
                    damage = 30;
                    max_health = 70;
                    health = max_health;
                    defense = 10;
                    break;
                case 3:
                    damage = 17;
                    max_health = 90;
                    health = max_health;
                    defense = 20;
                    break;
            }

            Console.Write("이름을 입력해주세요 : ");
            name = Console.ReadLine();

            Console.Clear();
            ShowInfo();
        }


    }
}
