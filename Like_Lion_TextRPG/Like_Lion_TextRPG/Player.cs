using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRPG
{
    class Player:Unit
    {
        public int level;
        public int strength;
        public int technique;
        public int intelligence;
        public int faith;
        public int mystery;
        public Player()
        {
            this.level = 1;
            this.tolerance = new Tolerance(0, 0);
            this.reducation = new Reducation(0, 0);
        }
        public void Setting_Class()
        {
            Console.WriteLine("이름을 정해주세요");
            this.name = Console.ReadLine();

            Console.WriteLine("\n직업을 선택해 주세요");
            Console.WriteLine("======================");
            Console.WriteLine("1. 방랑기사(미구현) ");
            Console.WriteLine("2. 검사(미구현)");
            Console.WriteLine("3. 도적(미구현)");
            Console.WriteLine("4. 빈털터리 ");
            Console.WriteLine("======================");
            int _input = int.Parse(Console.ReadLine());
            Choose_Class(_input);

        }

        public void Choose_Class(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("미구현입니다.");
                    break;
                case 2:
                    Console.WriteLine("미구현입니다.");
                    break;
                case 3:
                    Console.WriteLine("미구현입니다.");
                    break;
                case 4:
                    Choose_Begger();
                    Console.WriteLine("\n당신은 빈털터리입니다.");
                    break;
            }
        }

        public void Choose_Begger()
        {
            SetStats(100, 100, 20, 20, 30, 1, tolerance, reducation);
            this.strength = 10;
            this.technique = 10;
            this.intelligence = 10;
            this.faith = 10;
            this.mystery = 10;
        }

        public void Show_Char_Data()
        {
            Console.WriteLine("\n======캐릭터 데이터======");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Level : {level}");
            Console.WriteLine($"Hp : {hp} / {max_Hp}");
            Console.WriteLine($"Mp : {mp} / {max_Mp}");
            Console.WriteLine($"Stamina : {stamina}");
            Console.WriteLine($"Strength : {strength}");
            Console.WriteLine($"Technique : {technique}");
            Console.WriteLine($"Intelligence : {intelligence}");
            Console.WriteLine($"Faith : {faith}");
            Console.WriteLine($"Mystery : {mystery}");
            Console.WriteLine("====================================");
        }

        
    }
}
