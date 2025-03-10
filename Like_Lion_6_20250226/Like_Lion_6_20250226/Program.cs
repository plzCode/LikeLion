using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Like_Lion_6_20250226
{
    class Program
    {

        //1단계함수
        //반환형 함수이름 (매개변수)
        //{
        //}
        //1단계 기본형
        static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //2단계
        //입력
        static void AttackFunction(int Attack)
        {
            Console.WriteLine("공격력은 : " + Attack);
        }


        //3단계
        //출력
        static int BaseAttack()
        {
            //기본공격력 10
            int attack = 10;

            return attack; //출력
        }

        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int ReturnNumofString(string _str)
        {
            return _str.Length;
        }
        


        static void Main(string[] args)
        {
            /*int Attack = 0;
            int bAttack = 0;
            Console.WriteLine("캐릭터의 공격력을 입력 : ");
            Attack = int.Parse(Console.ReadLine());

            //기본공격력
            bAttack = BaseAttack();

            AttackFunction(bAttack + Attack);*/

            /*int a = 0;
            int b = 0;

            Console.Write("a값을 입력 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b값을 입력 :");
            b = int.Parse(Console.ReadLine());

            int result = Add(10, 20);
            Console.WriteLine($"{a} + {b} = {result}");*/

            /*string[] fruits = { "사과", "바나나", "체리" };

            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }*/

            //Q1.배열 요소 출력
            Console.WriteLine("=====1번 문제=====");
            Console.WriteLine("배열 요소 출력");
            int[] intArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                intArray[i] = (i + 1) * 10;
                Console.Write($"{intArray[i]} ");
            }
            Console.WriteLine();

            //Q2. 배열 요소의 합 구하기
            Console.WriteLine("\n=====2번 문제=====");
            Console.WriteLine("배열 요소의 합 구하기");
            int[] intArray_2 = new int[5];
            int sum = 0;
            for(int i =0; i < intArray_2.Length; i++)
            {
                Console.Write($"{i + 1}번 숫자를 입력하세요 : ");
                try
                {
                    intArray_2[i] = int.Parse(Console.ReadLine());
                    sum += intArray_2[i];
                }
                catch
                {
                    Console.WriteLine("제대로 된 숫자가 아닙니다.");
                    Console.ReadLine();
                    Console.Clear();
                    i--;
                }
            }
            Console.Write($"모든 수의 총합 : {sum}");
            Console.WriteLine();

            //Q3. 최대값 찾기
            Console.WriteLine("\n=====3번 문제=====");
            Console.WriteLine("최대값 찾기");
            int[] intArray_3 = new int[5];
            for (int i = 0; i < intArray_3.Length; i++)
            {
                Console.Write($"{i + 1}번 숫자를 입력하세요 : ");
                try
                {
                    intArray_3[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("제대로 된 숫자가 아닙니다.");
                    Console.ReadLine();
                    i--;
                }
            }
            Console.WriteLine(intArray_3.Max());
            Console.WriteLine();

            //Q4. 1부터 10까지 출력(for문)
            Console.WriteLine("\n=====4번 문제=====");
            Console.WriteLine("for문을 사용해 1부터 10까지 출력");

            for(int i = 0; i<10; i++)
            {
                Console.Write($"{i + 1} ");                
            }
            Console.WriteLine();

            //Q5. 짝수만 출력(while문)
            Console.WriteLine("\n=====5번 문제=====");
            Console.WriteLine("while문을 사용하여 짝수만 출력");

            int eveInt = 0;
            bool isFlag = true;

            while (isFlag)
            {
                Console.Write("입력하신 수까지의 모든 짝수를 출력합니다. : ");
                try
                {                
                    eveInt = int.Parse(Console.ReadLine());
                    isFlag = false;
                }
                catch
                {
                    continue;
                }
                int i = 1;
                while(i<= eveInt)
                {
                    if(i%2 == 0)
                    {
                        Console.Write(i.ToString("D2") +" ");
                        if (i%5 == 0)
                            Console.WriteLine();
                    }
                    i++;
                }
            }

            //Q6. 배열 요소 출력(foreach문)
            Console.WriteLine("\n=====6번 문제=====");
            Console.WriteLine("foreach문을 사용하여 배열 요소 출력");

            int[] intArray_6 = new int[5];
            for (int i = 0; i < intArray_6.Length; i++)
            {
                Console.Write($"{i + 1}번 숫자를 입력하세요 : ");
                try
                {
                    intArray_6[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("제대로 된 숫자가 아닙니다.");
                    Console.ReadLine();
                    i--;
                }
            }

            foreach(var tmpint in intArray_6)
            {
                Console.Write(tmpint + " ");
            }
            Console.WriteLine();

            //Q7. 두 수의 합을 구하는 함수
            Console.WriteLine("\n=====7번 문제=====");
            Console.WriteLine("두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.");

            int int7_a = 0;
            int int7_b = 0;

            while (true)
            {
                try
                {
                    Console.Write("숫자 a를 입력 : ");
                    int7_a = int.Parse(Console.ReadLine());
                    Console.Write("숫자 b를 입력 : ");
                    int7_b = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("제대로 된 숫자가 아닙니다.\n");
                    continue;
                }
                Console.WriteLine($"{int7_a} + {int7_b} = {Add(int7_a, int7_b)}");
                break;
            }

            //Q8.문자열 길이 반환 함수
            Console.WriteLine("\n=====8번 문제=====");
            Console.WriteLine("문자열을 입력받고 해당 문자열의 길이를 반환하는 함수 작성");

            string str = "";

            Console.Write("문자열을 입력해주세요 : ");
            str = Console.ReadLine();

            Console.WriteLine($"문자열의 길이는 : {ReturnNumofString(str)}입니다.");

            //Q9. 가장 큰 수 반환 함수
            Console.WriteLine("\n=====9번 문제=====");
            Console.WriteLine("n개의 숫자를 입력받고 가장 큰값을 반환하는 함수 작성");

            float max = ReturnMaxFloat();
            Console.WriteLine($"입력하신 수 중에서 가장 큰 수는 {max}입니다.");
        }
        static float ReturnMaxFloat()
        {
            float max = 0.0f;
            List<float> floatList = new List<float>();
            while (true)
            {
                try
                {
                    Console.Write("숫자를 입력하세요 : ");
                    floatList.Add(float.Parse(Console.ReadLine()));
                }
                catch
                {
                    break;
                }
            }

            max = floatList.Max();

            return max;
        }


    }
}
