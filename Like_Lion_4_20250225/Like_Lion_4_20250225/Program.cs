using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Like_Lion_4_20250225
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int day = 3;

            switch(day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("무효");
                    break;
            }*/
            /*
                        string char_class_string = "";
                        float char_power = 0f;
                        float char_defense = 0f;
                        while (true)
                        {
                            Console.Write("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적) : ");
                            int char_class = int.Parse(Console.ReadLine());
                            bool while_flag = true;
                            switch (char_class)
                            {                    
                                case 1:
                                    char_class_string = "검사";
                                    char_power = 100;
                                    char_defense = 90;
                                    break;
                                case 2:
                                    char_class_string = "마법사";
                                    char_power = 110;
                                    char_defense = 80;
                                    break;
                                case 3:
                                    char_class_string = "도적";
                                    char_power = 115;
                                    char_defense = 70;
                                    break;
                                default:
                                    while_flag = false;
                                    Console.WriteLine("잘못된 숫자를 입력하셨습니다.");
                                    break;
                            }
                            if(while_flag == true)
                            {
                                break;
                            }
                        }

                        Console.WriteLine($"클래스 : {char_class_string}, 공격력 : {char_power}, 방어력 : {char_defense}");
            */
            /*
                        int sum = 0;
                        for(int i = 0; i<10; i++)
                        {
                            sum += i + 1;

                        }

                        Console.WriteLine(sum);
            */
            /*
                        Random rand = new Random();
                        for(int i = 0;i <10; i++)
                        {
                            int randNum = rand.Next(0, 10); //0~9
                            Console.WriteLine("0이상 10미만의 정수 : " + randNum);
                        }
            */
            /*
                        //대장장이 키우기
                        *//*
                                    도끼 등급 SSS   1%
                                    도끼 등급 SS    5%
                                    도끼 등급 S     10%
                        *//*

                        Random rand = new Random();

                        for(int i = 0; i<10; i++)
                        {
                            int tmpInt = rand.Next(0, 100);
                            string axeGrade = "";
                            if (tmpInt < 1) //1%
                            {
                                axeGrade = "SSS";
                            }
                            else if(tmpInt <= 5) //5% 1 ~ 5
                            {
                                axeGrade = "SS";
                            }
                            else if(tmpInt <= 15) // 6 ~ 15
                            {
                                axeGrade = "S";
                            }
                            else
                            {
                                axeGrade = "꽝";
                            }

                                Console.WriteLine($"{i + 1}번째 뽑기 : {axeGrade}");
                        }
            */
            /*
                        int x = 5;

                        do
                        {
                            Console.WriteLine("최소 한번은 실행됩니다.");
                            x--;
                        } while (x > 0);


                        for (int i = 1; i <= 10; i++)
                        {
                            if (i == 5)
                            {
                                break;
                            }


                            Console.WriteLine(i);
                        }
            */
            /*
                        for(int i = 0; i<10; i++)
                        {
                            if(i%2 == 0)
                            {
                                continue;
                            }
                            Console.WriteLine("홀수만 출력 : " + i);
                        }
            */
            /*
            int n = 1;

            start:
            if (n <= 5)
            {
                Console.Write(n);
                n++;
                goto start; //레이블로 이동
            }
            */

            //대장장이 키우기
            //나무 캐기
            //장비 뽑기 
            //나가기

            int wood = 0;
            List<string> inventory = new List<string>();
            


        }
    }
}
