using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_3_20250224
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Console.Write("2진수를 입력하세요 : ");
                        string binInput = Console.ReadLine();
                        int demical = Convert.ToInt32(binInput, 2); //2진수 -> 10진수

                        //정수 -> 2진수
                        string binOutput = Convert.ToString(demical, 2); // 10진수 -> 2진수
                        Console.WriteLine($"입력한 수 {binInput}");
                        Console.WriteLine($"10진수로 변환 {demical}");
                        Console.WriteLine($"다시 이진수로 {binOutput}");
            */
            /*
                        var str = "Alice";
                        var intNum = 15;
                        var floatNum = 15.1234f;
                        var isBool = true;

                        Console.WriteLine(str);
                        Console.WriteLine(intNum);
                        Console.WriteLine(floatNum);
                        Console.WriteLine(isBool);
            */
            /*
                        //defualt 키워드를 사용한 기본값 설정
                        string str = default; //""
                        int intNum = default; //0
                        bool isbool = default; //False

                        Console.WriteLine($"string : {str}, int : {intNum}, bool : {isbool}");
            */
            /*
                        int a = 3, b = 5;
                        bool c = true, d = false;

                        int sum = a + b;
                        int sub = a - b;
                        int mul = a * b;
                        int div = a / b;
                        int remainder = a % b;

                        Console.WriteLine($"sum : {sum}, sub : {sub}, mul : {mul}, div : {div}, remainder : {remainder}");
                        Console.WriteLine($"And : {c && d}, Or : {c || d}");
            */
            /*
                        //홀짝 판별
                        int inputNumInt = 0;

                        Console.Write("숫자를 입력하시오 : ");
                        string inputNumStr = Console.ReadLine();

                        inputNumInt = int.Parse(inputNumStr);

                        bool isEven = false;
                        if(inputNumInt % 2 == 0)
                        {
                            isEven = true;
                        }
                        Console.WriteLine($"이 수가 짝수면 true가 출력이 됩니다 : {isEven}");
            */
            /*
                        int a = 0;
                        int b = 1;

                        bool isEqual = a == b;
                        Console.Write($"같은 수인가? : {isEqual}");
            */
            /*
                        bool isFlag = true;
                        Console.Write(!isFlag);
            */
            /*
                        //비트 반전
                        //10 1010
                        //   0101
                        int num = 10;
                        int result = ~num; //모든 비트 반전 10 -> -11

                        Console.WriteLine(result);
            */
            /*
                        //캐스팅
                        double pi = 3.141592653589793238462643383;
                        int integerPi = (int)pi;

                        Console.WriteLine(integerPi);
            */
            /*
                        int ikor = 90;
                        int ieng = 75;
                        int imath = 58;

                        int sum = 0;
                        float average = 0.0f;

                        sum = ikor + ieng + imath;
                        average = (float)sum / 3;

                        Console.WriteLine($"총점 : {sum} , 평균 : {average}");
            */
            /*
                        int a = 10, b = 3;

                        Console.WriteLine(a + b);
                        Console.WriteLine(a - b);
                        Console.WriteLine(a * b);
                        Console.WriteLine(a / b);
                        Console.WriteLine(a % b);
            */
            /*
                        string firstName = "Alice";
                        string lastName = "Smith";

                        Console.WriteLine(firstName + " " + lastName);
            */
            /*
                        int a = 10;

                        a += 5;
                        Console.WriteLine(a);
                        a -= 5;
                        Console.WriteLine(a);
                        a *= 5;
                        Console.WriteLine(a);
                        a /= 5;
                        Console.WriteLine(a);
                        a %= 5;
                        Console.WriteLine(a);
                        */
            /*
                        //quest
                        Console.WriteLine("국어 점수를 입력하시오: ");
                        string koreanStr = Console.ReadLine();
                        int korean = int.Parse(koreanStr);
                        Console.WriteLine("영어 점수를 입력하시오: ");
                        string englishStr = Console.ReadLine();
                        int english = int.Parse(englishStr);
                        Console.WriteLine("수학 점수를 입력하시오: ");
                        string mathStr = Console.ReadLine();
                        int math = int.Parse(mathStr);

                        int sum = korean + english + math;
                        float avg = (float)sum / 3.0f;

                        Console.WriteLine("총점 : " + sum);
                        Console.WriteLine("평균 : " + avg);
            */
            /*
                        //quest2
                        Console.WriteLine("정수를 입력하십시오 : ");
                        string inputStr = Console.ReadLine();
                        int inputInt = int.Parse(inputStr);

                        Console.WriteLine($"원래 정수의 : {inputInt} \n비트반전 후 정수의 값 : {~inputInt} ");
            */
            /*
                        int a = 0;

                        Console.WriteLine(a++);
                        Console.WriteLine(++a);
                        Console.WriteLine(a--);
                        Console.WriteLine(--a);
            */
            /*
                        Console.WriteLine(3 < 5);
                        Console.WriteLine(3 == 3);
                        Console.WriteLine(3 > 5);

                        Console.WriteLine(true && false);
                        Console.WriteLine(true && true);
                        Console.WriteLine(true || false);
                        Console.WriteLine(false || false);
                        Console.WriteLine(!false);
            */
            /*
                        int x = 10; //1010;
                        int y = 2; //0010;

                        Console.WriteLine(x&y); //0010;
                        Console.WriteLine(x|y); //1010;
                        Console.WriteLine(x^y); //1000;
                        Console.WriteLine(~x); //-11
            */
            /*
                        int value = 4; //0100;
                        Console.WriteLine(value<<1);
                        Console.WriteLine(value >> 1);
            */
            /*
                        int a = 10, b = 20;
                        int max = (a > b) ? a : b;
                        Console.WriteLine(max);

                        int key = 1;
                        string str;
                        str = key == 1 ? "문이열림" : "문이 열리지 않음";
                        Console.WriteLine(str);
            */

            /*
            int result = 10 + 2 * 5;
            Console.WriteLine(result);

            int adjustResult = (10 + 2) * 5;
            Console.WriteLine(adjustResult);
            */
            /*
                        Console.Write("점수를 입력하세요 : ");
                        string scoreStr = Console.ReadLine();
                        int score = int.Parse(scoreStr);
                        string resultStr = "";
                        if (score >= 90)
                        {
                            resultStr = "A";
                        }
                        else if (score >= 80) 
                        {
                            resultStr = "B";
                        }
                        else
                        {
                            resultStr = "C";
                        }
                        Console.WriteLine($"{resultStr}학점입니다.");
            */
            /*
                        string id = "멋쟁이사자";
                        Console.Write("아이디를 입력하세요 : ");
                        string inputId = Console.ReadLine();

                        if(id == inputId)
                        {
                            Console.WriteLine("아이디가 일치합니다");
                        }
                        else
                        {
                            Console.WriteLine("불일치");
                        }
            */
            /*
                        float charPower = 100;
                        Console.Write("캐릭터의 이름을 입력하세요 : ");
                        string inputName = Console.ReadLine();

                        Console.Write("가지고 있는 소지금을 입력하세요 :");
                        string inputStr = Console.ReadLine();
                        int inputInt = int.Parse(inputStr);

                        string itemName = "";
                        float addPower = 0.0f;

                        if (inputInt > 600)
                        {
                            addPower += 999;
                        }
                        else if (inputInt > 500)
                        {
                            addPower = 6;
                        }
                        else if (inputInt > 400)
                        {
                            addPower = 5;
                        }
                        else if (inputInt > 300)
                        {
                            addPower = 4;
                        }
                        else if (inputInt > 200)
                        {
                            addPower = 3;
                        }
                        else if (inputInt > 100)
                        {
                            addPower = 2;
                        }
                        else if(inputInt > 1)
                        {
                            addPower = 1;
                        }
                        else
                        {
                            addPower = 0;
                        }
                        charPower += addPower;

                        Console.WriteLine("캐릭터 이름 : " + inputName);
                        Console.WriteLine("캐릭터 공격력 : " + charPower);
            */
            /*
                        string charName = "";
                        string inputGold_str = "";
                        int inputGold_int = 0;
                        int userGold = 0;
                        int charPower = 100;
                        Dictionary<string, int> item_shop = new Dictionary<string, int>();

                        item_shop["무한의 대검"] = 100;
                        item_shop["카타나"] = 200;
                        item_shop["진은검"] = 300;
                        item_shop["집판검"] = 400;
                        item_shop["엑스칼리버"] = 500;
                        item_shop["유령검"] = 600;

                        Console.Write("캐릭터의 이름을 입력하세요 : ");
                        charName = Console.ReadLine();
                        Console.Write("가지고 있는 소지금을 입력하세요 : ");
                        inputGold_str = Console.ReadLine();
                        inputGold_int = int.Parse(inputGold_str);
                        userGold += inputGold_int;


                        while (true)
                        {

                            Console.WriteLine("-----------------------------");

                            foreach (var item in item_shop)
                            {
                                Console.WriteLine($"{item.Key} : {item.Value}G ");
                            }

                            Console.WriteLine("-----------------------------"); 
                            Console.WriteLine("어느 무기를 구매하시겠습니까? ");
                            string buyItem = Console.ReadLine();

                            if (item_shop.ContainsKey(buyItem))
                            {
                                userGold -= item_shop[buyItem];
                                charPower += item_shop[buyItem] / 100;
                                break;
                            }

                        }

                        Console.WriteLine("캐릭터 파워 : " + charPower);
                        Console.WriteLine("남은 소지금 : " + userGold);
                     */
            /*
                        //Quest1
                        Console.WriteLine("======문제 1번======");
                        string a_str = "";
                        string b_str = "";
                        string c_str = "";

                        int a = 0;
                        int b = 0;
                        int c = 0;

                        Console.Write("숫자 A를 입력하세요 : ");
                        a_str = Console.ReadLine();
                        Console.Write("숫자 B를 입력하세요 : ");
                        b_str = Console.ReadLine();
                        Console.Write("숫자 C를 입력하세요 : ");
                        c_str = Console.ReadLine();

                        a = int.Parse(a_str);
                        b = int.Parse(b_str);
                        c = int.Parse(c_str);

                        int max = -999;
                        if (a > b)
                        {
                            if (a > c) max = a;
                            else max = c;
                        }
                        else
                        {
                            if (b > c) max = b;
                            else max = c;
                        }
                        Console.WriteLine(Math.Max(a, Math.Max(b, c)));
                        //Console.WriteLine(max);
            */
            /*
                        //Quest2
                        Console.WriteLine("======문제 2번======");
                        Console.Write("점수를 입력하세요 : ");
                        string scoreStr = Console.ReadLine();
                        int score = int.Parse(scoreStr);
                        string resultStr = "";
                        if (score >= 90)
                        {
                            resultStr = "A";
                        }
                        else if (score >= 80)
                        {
                            resultStr = "B";
                        }
                        else if (score >= 70)
                        {
                            resultStr = "C";
                        }
                        else if (score >= 60)
                        {
                            resultStr = "D";
                        }
                        else
                        {
                            resultStr = "F";
                        }
                        Console.WriteLine($"{resultStr}학점입니다.");
            */

            /*
                        //Quest3
                        Console.WriteLine("======문제 3번======");
                        while (true)
                        {

                            string symbol = "";
                            string a_str_3 = "";
                            string b_str_3 = "";

                            float a3 = 0f;
                            float b3 = 0f;

                            float result = 0f;

                            Console.Write("기호를 입력하세요 : ");
                            symbol = Console.ReadLine();

                            try
                            {
                                Console.WriteLine("숫자 A를 입력하세요 : ");
                                a_str_3 = Console.ReadLine();
                                a3 = float.Parse(a_str_3);


                                Console.WriteLine("숫자 B를 입력하세요 : ");
                                b_str_3 = Console.ReadLine();
                                b3 = float.Parse(b_str_3);
                            }
                            catch
                            {
                                Console.WriteLine("제대로 된 숫자가 아닙니다.");
                                Console.ReadLine();
                                continue;
                            }


                            if (symbol == "+")
                            {
                                result = a3 + b3;
                            }
                            else if (symbol == "-")
                            {
                                result = a3 - b3;
                            }
                            else if (symbol == "*")
                            {
                                result = a3 * b3;
                            }
                            else if (symbol == "/")
                            {
                                if (b3 == 0)
                                {
                                    Console.WriteLine("0으로는 나눌 수 없습니다. ");
                                    Console.ReadLine();
                                    Console.Clear();
                                    continue;
                                }
                                result = a3 / b3;
                            }
                            else if (symbol == "%")
                            {
                                result = a3 % b3;
                            }
                            else
                            {
                                Console.WriteLine("제대로 된 기호가 아닙니다.");
                                Console.ReadLine();
                                continue;
                            }

                            Console.WriteLine("----------------\n" + $"{a3} {symbol} {b3} = {result}");
                            Console.ReadLine();
                            Console.Clear();

                        }
            */

            
        }
    }
}
