using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_12_20250304
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===1. 클래스와 상속===");
            Warrior horaru = new Warrior();

            while (true) 
            {
                try
                {
                    Console.Write("Warrior의 이름은 : ");
                    horaru.name = Console.ReadLine();

                    Console.Write("Warrior의 점수는 : ");
                    horaru.score = int.Parse(Console.ReadLine());

                    Console.Write("Warrior의 힘은 : ");
                    horaru.strength = float.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("잘못된 입력");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            Console.WriteLine($"\nWarrior의 이름은 {horaru.name} / 점수는 {horaru.score} / 힘은 {horaru.strength}입니다. ");
            Console.WriteLine();

            Console.WriteLine("\n===2. 예외 처리===");
            int a_2 = 0;


            while (true)
            {
                try
                {
                    Console.Write("int형 변수를 입력해 주세요 : ");
                    a_2 = int.Parse(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("올바른 숫자를 입력하세요!");
                    continue;
                }
                break;
            }
            Console.WriteLine($"정상적으로 int형 변수인 {a_2}가 입력되었습니다.");

            Console.WriteLine("\n===3. 컬렉션(List, Queue, Stack)활용===");
            List<string> fruits = new List<string>();
            fruits.Add("사과");
            fruits.Add("바나나");
            fruits.Add("포도");

            foreach(var fruit in fruits)
            {
                Console.WriteLine($"fruits List : {fruit}");
            }

            Queue<string> works = new Queue<string>();
            works.Enqueue("첫 번째 작업");
            works.Enqueue("두 번째 작업");
            works.Enqueue("세 번째 작업");

            foreach (var work in works) 
            {
                Console.WriteLine($"Works Queue : {work}");
            }

            Stack<int> a_3 = new Stack<int>();
            a_3.Push(10);
            a_3.Push(20);
            a_3.Push(30);

            foreach(var i_tmp in a_3)
            {
                Console.WriteLine($"int Stack : {i_tmp}");
            }

            Console.WriteLine("\n===4.문자열 처리===");
            Console.Write("문자열을 입력하세요. : ");
            string str = Console.ReadLine();

            Console.WriteLine($"대문자 출력 : {str.ToUpper()}");
            Console.WriteLine($"C#을 CSharp으로 대체 : {str.Replace("C#", "CSharp")}");
            Console.WriteLine($"문자열의 길이를 출력 : {str.Length}");

            Console.WriteLine("\n===5. LINQ 활용 ===");
            int[] numbers = new int[10];
            for(int i = 0; i<10; i++)
            {
                numbers[i] = i + 1;
            }
            var evenNum = numbers.Where(n => n % 2 == 0);

            foreach(var eve in evenNum)
            {
                Console.Write($"{eve}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"Linq를 사용하여 모든 숫자의 합을 구하기 : {numbers.Sum()}");
        }
    }

    public class Warrior
    {
        public string name;
        public int score;
        public float strength; 
    }
}

