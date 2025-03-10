using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_TextRpg_Test
{
    class Field
    {
        public string map_name = "";
        public List<Monster> boss = null;

        public void Choose_Field()
        {
            int i_input;
            while (true)
            {
                try
                {
                    Console.WriteLine("=== 맵 선택 ===");
                    Console.WriteLine("1. 스톰빌 성");
                    Console.WriteLine("2. 마술학원 레아 루카리아");
                    Console.WriteLine("3. 적사자 성");

                    Console.Write("어디로 이동할까 : ");
                    i_input = int.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
                break;
                
            }            

            boss = SettingMap(i_input);
        }

        public List<Monster> SettingMap(int i_input)
        {
            List<Monster> mobs = new List<Monster>();

            while (true)
            {
                try
                {
                    switch (i_input)
                    {
                        case 1:
                            map_name = "스톰빌 성";
                            Stormvill map1 = new Stormvill();
                            mobs = map1.mobList;
                            break;
                        case 2:
                            map_name = "마술학원 레아 루카리아";
                            MagicSchool map2 = new MagicSchool();
                            mobs = map2.mobList;
                            break;
                        case 3:
                            map_name = "적사자 성";
                            RedLion_Castle map3 = new RedLion_Castle();
                            mobs = map3.mobList;
                            break;

                    }
                }
                catch
                {
                    continue;
                }
                break;
            }
            
            return mobs;
        }

        public void Show_Map()
        {
            Console.WriteLine($"지역 : {map_name}");
        }
    }
    class Stormvill
    {
        public List<Monster> mobList = new List<Monster>();

        public Stormvill()
        {
            mobList.Add(new Monster("접목의 고드릭", 3, 180, 2));
        }

        
    }

    class MagicSchool 
    {
        public List<Monster> mobList = new List<Monster>();
        public MagicSchool()
        {
            mobList.Add( new Monster ("만월의 여왕, 레날라", 30, 40, 3));

        }
    }

    class RedLion_Castle
    {
        public List<Monster> mobList = new List<Monster>();

        public RedLion_Castle()
        {
            mobList.Add(new Monster("별 부수는 라단", 15, 90, 10));
        }
    }

    
    }
