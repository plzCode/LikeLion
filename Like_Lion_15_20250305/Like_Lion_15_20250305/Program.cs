using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Like_Lion_15_20250305
{
    class Program
    {

        public class Champ
        {
            public string name { get; set; }
            public int level { get; set; } = 1;
            public float exp { get; set; } = 0.0f;

            public int max_health { get; set; }
            public int health { get; set; }

            public int max_mana { get; set; }
            public int mana { get; set; }

            public float ad_Power { get; set; }    // 공격력
            public float ad_Defense { get; set; }  // 방어력

            public int level_per_health { get; set; }
            public int level_per_mana { get; set; }
            public float level_per_ad { get; set; }
            public float level_per_ad_Defense { get; set; }

            public List<Skill> skills { get; set; } = new List<Skill>();  // 스킬 리스트
            public List<Item> items { get; set; } = new List<Item>();

            // 레벨 업 메서드
            public void LevelUp()
            {
                level++;
                max_health += level_per_health;
                health += level_per_health; 
                max_mana += level_per_mana;
                mana = level_per_mana; 
                ad_Power += level_per_ad;
                ad_Defense += level_per_ad_Defense;

                Console.WriteLine($"{name}이(가) {level} 레벨로 성장했습니다!");
            }

            public void ShowInfo()
            {
                Console.WriteLine("========== 챔피언 정보 ==========");
                Console.WriteLine($"이름     : {name}");
                Console.WriteLine($"레벨     : {level}");
                Console.WriteLine($"체력     : {health} / {max_health}");
                Console.WriteLine($"마나     : {mana} / {max_mana}");
                Console.WriteLine($"공격력   : {ad_Power}");
                Console.WriteLine($"방어력   : {ad_Defense}");
                Console.WriteLine("=================================");
            }

        }

        

        public class Item
        {

        }

        public class WarWick : Champ
        {
            public WarWick()
            {
                name = "WarWick";
                max_health = 620;
                health = max_health;
                max_mana = 280;
                mana = max_mana;

                ad_Power = 60;
                ad_Defense = 33;

                level_per_health = 99;
                level_per_mana = 35;
                level_per_ad = 2.75f;
                level_per_ad_Defense = 4.4f;

                skills = new List<Skill>() { new HungeringStrike() };
            }
        }
        public class Skill
        {
            public string name { get; set; }
            public int[] manaCost { get; set; }
            public float[] cooTime { get; set; }

            public int level { get; set; }

            public float per_ad { get; set; }

            private DateTime lastUsedTime = DateTime.MinValue; //마지막 사용 시간


            public virtual bool Use(Champ champ, Champ target = null)
            {
                if(level <= 0)
                {
                    Console.WriteLine($"아직 스킬을 배우지 않았습니다.");
                    return false;
                }

                double elapsedSeconds = (DateTime.Now - lastUsedTime).TotalSeconds;
                if (elapsedSeconds < cooTime[level - 1])
                {
                    Console.WriteLine($"{name} 스킬은 재사용 대기 중입니다. ({cooTime[level - 1] - elapsedSeconds:F2}초 남음)");
                    return false;
                }

                if (champ.mana < manaCost[level - 1])
                {
                    Console.WriteLine($"{champ.name}의 마나가 부족합니다.");
                    return false;
                }

                champ.mana -= manaCost[level - 1];
                lastUsedTime = DateTime.Now; // 스킬 사용 시간 갱신
                Console.WriteLine($"{champ.name}이(가) {manaCost}을 사용했습니다.");

                if (target != null)
                {
                    Console.WriteLine($"{target.name}에게 피해를 줍니다.");
                }
                return true;
            }
        }

        public class HungeringStrike : Skill
        {
            public HungeringStrike()
            {
                name = "Hungering Strike";
                manaCost = new int[] { 80, 85, 90, 95, 100 };
                cooTime = new float[] { 8, 7.5f, 7, 6.5f, 6 };
            }

            public override bool Use(Champ champ, Champ target)
            {
                if (!base.Use(champ, target)) return false; // 부모에서 스킬 사용 실패하면 중단

                champ.health += 50; // 체력 회복
                if (champ.health >= champ.max_health)
                {
                    champ.health = champ.max_health;
                }
                Console.WriteLine($"{champ.name}이(가) {name}을 사용해 체력을 회복했습니다! (현재 체력: {champ.health})");
                return true;
            }
        }


        

        static void Main(string[] args)
        {
            Dictionary<ConsoleKey, bool> keyStates = new Dictionary<ConsoleKey, bool>(); // 키 상태 저장
            WarWick warwick = new WarWick();

            warwick.ShowInfo();
            Console.WriteLine();
            
            while (true)
            {
                // 키 입력 감지
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    // Ctrl 키가 함께 눌렸는지 확인
                    bool isCtrlPressed = (keyInfo.Modifiers & ConsoleModifiers.Control) != 0;

                    keyStates[keyInfo.Key] = true;

                    // Ctrl + Q 입력 감지
                    if (isCtrlPressed && keyInfo.Key == ConsoleKey.Q)
                    {
                        // 스킬 레벨 업
                        if (warwick.skills[0].level < 5)
                        {
                            warwick.skills[0].level++;
                            Console.WriteLine($"스킬 {warwick.skills[0].name}의 레벨이 {warwick.skills[0].level}로 증가했습니다!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("스킬 레벨이 최대입니다!");
                            Console.WriteLine();
                        }

                        // 중복 실행 방지를 위해 키 상태 초기화
                        keyStates[ConsoleKey.Q] = false;
                    }
                    else if (keyInfo.Key == ConsoleKey.Q)
                    {
                        warwick.skills[0].Use(warwick);
                        keyStates[ConsoleKey.Q] = false;
                        Console.WriteLine();
                        warwick.ShowInfo();
                    }
                }

                Thread.Sleep(50); // CPU 점유율 방지

            }

        }
    }
}
