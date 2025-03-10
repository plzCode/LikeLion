using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_12_20250305
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] names = {"Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);

            foreach(var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(sortedNames.ToArray()[0]);

            var firstName = names.First(n => n.StartsWith("A"));
            Console.WriteLine(firstName);*/

            /*int[] nums = { 5, 3, 8, 1 };
            var sortedMeshod = nums.OrderBy(n => n);
            var sortedQuery = from n in nums
                              orderby n
                              select n;

            
            foreach (var n in sortedMeshod)
                Console.WriteLine(n);

            foreach (var n in sortedQuery)
                Console.WriteLine(n);*/

            /*string[] words = { "apple", "banana", "cherry" };

            //select()로 길이 추출

            var lengths = words.Select(w => w.Length);

            foreach(var len in lengths)
            {
                Console.WriteLine(len);
            }

            var upperWords = words.Select(n => n.ToUpper());
            foreach(var up in upperWords)
            {
                Console.WriteLine(up);
            }*/

            /*int[] data = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (var d in data)
                sum += d;

            Console.WriteLine($"Sum : {sum}");*/

            /*int[] data = { 1, 5, 3, 2, 5 };
            int count = data.Length;
            Console.WriteLine($"Count : {count}");
            float avg = (float)data.Average();
            Console.WriteLine($"Average : {avg:F2}");
            int max = data.Max();
            Console.WriteLine($"MAX : {max}");
            int min = data.Min();
            Console.WriteLine($"Min : {min}");*/

            /*int[] data = { 10, 12, 20, 25, 30 };
            int target = 22;
            int nearest = data[0];

            foreach(var d in data)
            {
                if (Math.Abs(d - target) < Math.Abs(nearest - target))
                {
                    nearest = d;
                }
            }
            Console.WriteLine(nearest);*/

            /*int[] scores = { 90, 70, 50, 70, 60 };

            for (int i = 0; i < scores.Length; i++)
            {
                int rank = 1;

                for (int j = 0; j < scores.Length; j++)
                {
                    if (scores[j] > scores[i])
                        rank++;
                }
                Console.WriteLine($"Score : {scores[i]} ,Rank:{rank}");
            }*/

            /*//특정 값 검색하기: Search 알고리즘
            int[] data = { 5, 2, 8, 1, 9 };
            int target = 8;
            int index = -1;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");*/

            /*string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            var groups = fruits.GroupBy(f => f[0]); //첫글자로 그룹화
            foreach(var group in groups)
            {
                Console.WriteLine($"Key : {group.Key}");
                foreach(var item in group)
                {
                    Console.WriteLine($"{item}");
                }
            }*/

            /*Dog myDog = new Dog();
            myDog.Name = "바둑이"; //부모 클래스의 속성 사용
            myDog.Eat();  //부모 클래스의 메서드 호출 가능
            myDog.Bark(); //자기 메서드 호출 가능 */

            Player p = new Player();  //객체

            p.name = "홍길동";
            p.Render();


            Wizard w = new Wizard();
            w.name = "대마법사 샤우론";
            w.job = "마법사";

            w.Render();
            w.Render2();


        }

        class Player
        {
            public string name;

            public void Render()
            {
                Console.WriteLine("플레이어" + name);
            }
        }

        class Wizard : Player
        {
            public string job;
            public void Render2()
            {
                Console.WriteLine("직업은 " + job + "입니다.");
            }

        }

        class Animal
        {
            public string Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
            }
        }

        //자식 클래스 (파생 클래스)
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.!");
            }
        }

        
    }
}
