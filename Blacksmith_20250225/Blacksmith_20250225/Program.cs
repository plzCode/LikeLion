using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blacksmith_20250225
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();

            int wood = 0;
            List<string> inv = new List<string>();

            Dictionary<string, string> itemList = new Dictionary<string, string>();
            itemList.Add("SSS", "SSS급 도끼");
            itemList.Add("SS", "SS급 도끼");
            itemList.Add("S", "S급 도끼");
            itemList.Add("A", "A급 도끼");
            itemList.Add("B", "B급 도끼");
            itemList.Add("C", "C급 도끼");

            while (true)
            {
                Console.Write("무엇을 하시겠습니까?(1. 나무캐기 2. 장비뽑기) : ");
                int inputAction = 0;
                try
                {
                    inputAction = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("제대로 된 숫자를 입력해주세요.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                switch (inputAction)
                {
                    case 1:
                        {
                            wood += TakeWood();
                            Console.WriteLine("현재 보유한 목재량 : " + wood);
                            break;
                        }
                    case 2:
                        {
                            if(wood >= 10)
                            {
                                wood -= 10;
                                string item = GetItem(itemList);
                                inv.Add(item);
                                Console.WriteLine(item + "을 획득했다.");
                                break;
                            }
                            Console.WriteLine("목재가 부족해요.");
                            break;
                        }
                    default:
                        Console.WriteLine("제대로 된 숫자를 입력해주세요.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                }



            }


        }

        static int TakeWood()
        {
            Random rand = new Random();
            int num = rand.Next(10, 101); //10~100
            Console.WriteLine(num + "의 목재를 얻었다.");
            return num;
        }

        static string GetItem(Dictionary<string, string> itemList)
        {
            Random rand = new Random();
            int randomInt = -999;
            string returnItem = "";
            List<string> sssGrade = new List<string>();
            List<string> ssGrade = new List<string>();
            List<string> sGrade = new List<string>();
            List<string> aGrade = new List<string>();
            List<string> bGrade = new List<string>();
            List<string> cGrade = new List<string>();

            foreach (var itemKey in itemList)
            {
                switch (itemKey.Key)
                {
                    case "SSS":
                        sssGrade.Add(itemKey.Value);
                        break;
                    case "SS":
                        ssGrade.Add(itemKey.Value);
                        break;
                    case "S":
                        sGrade.Add(itemKey.Value);
                        break;
                    case "A":
                        aGrade.Add(itemKey.Value);
                        break;
                    case "B":
                        bGrade.Add(itemKey.Value);
                        break;
                    case "C":
                        cGrade.Add(itemKey.Value);
                        break;
                    default:
                        break;

                }
            }
            randomInt = rand.Next(0, 100);
            if(randomInt < 1) //1%
            {
                randomInt = rand.Next(0, sssGrade.Count);
                returnItem = sssGrade[randomInt];
            }
            else if(randomInt < 6) //5%
            {
                randomInt = rand.Next(0, ssGrade.Count);
                returnItem = ssGrade[randomInt];
            }
            else if (randomInt < 16) //10%
            {
                randomInt = rand.Next(0, sGrade.Count);
                returnItem = sGrade[randomInt];
            }
            else if (randomInt < 36) //20%
            {
                randomInt = rand.Next(0, aGrade.Count);
                returnItem = aGrade[randomInt];
            }
            else if (randomInt < 66) //30%
            {
                randomInt = rand.Next(0, bGrade.Count);
                returnItem = bGrade[randomInt];
            }
            else
            {
                randomInt = rand.Next(0, cGrade.Count);
                returnItem = cGrade[randomInt];
            }



                return returnItem;
        }

    }


}
