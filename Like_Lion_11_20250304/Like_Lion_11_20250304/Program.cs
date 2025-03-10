using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Like_Lion_11_20250304
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("프로그램 종료");

            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine($"PATH: {path}");

            Environment.Exit(0);*/

            /*Stopwatch stopwatch = Stopwatch.StartNew();

            //실행코드
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1);
            }
            //0.001

            stopwatch.Stop();

            Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms");*/

            /*string input = "Hello, my phone number is 010-1234-5678.";
            string parttern = @"\d{3}-\d{4}-\d{4}";

            bool isMatch = Regex.IsMatch(input, parttern);
            Console.WriteLine($"전화번호가 존재하는가? {isMatch}");*/

            /*int valueType = 10;
            object referenceType = valueType;

            valueType = 20;

            Console.WriteLine($"ValueType : {valueType}"); //20
            Console.WriteLine($"ReferenceType: {referenceType}");*/

            //박싱 언박싱
            //값 형식을 참조형식으로 변환(박싱) , 다시 값 형식으로 변환(언박싱)

            /*int value = 42;
            object boxed = value; //박싱
            int unboxed = (int)boxed; //언방식

            Console.WriteLine($"Boxed: {boxed}, Unboxed : {unboxed}");*/

            //is 연산자 형식 비교하기
            //객체가 특정형식인지 확인할 수 있다.
            /*object obj = "Hello";
            Console.WriteLine(obj is string); //True
            Console.WriteLine(obj is int); //False
*/
            //as 연산자로 형식 변환하기
            //as 연산자를 사용해 안전하게 형 변환을 수행

            /*object obj = "Hello";
            string str = obj as string;
            Console.WriteLine(str is string);*/

            /*object obj = 42;


            if (obj is int number)
            {
                Console.WriteLine($"Number : {number}");
            }
            else
            {
                Console.WriteLine("Not a number");
            }*/

            /*string greeting = "Hello";
            string name = "Alice";

            string message = greeting + "," + name + "!";
            Console.WriteLine(message); //Hello,Alice

            Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
            Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
            Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열*/

            //string 다양한 메서드
            /*string text = "C# is awesome!";
            Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");
            Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")} ");*/

            /*StringBuilder sb = new StringBuilder("Hello");
            sb.Append(",");
            sb.Append("World!");
            Console.WriteLine(sb.ToString());*/

            //String과 StringBuilder클래스 성능차이 비교
            //반복적으로 문자열을 수정할때 StringBuilder가 효율적이다.

            /*int iterations = 10000;

            Stopwatch sw = Stopwatch.StartNew();

            string text = "";

            for (int i = 0; i < iterations; i++)
            {
                text += "a";
            }

            sw.Stop();
            Console.WriteLine($"String  : {sw.ElapsedMilliseconds}ms");

            sw.Restart();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }

            sw.Stop();
            Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");*/

            //예외처리하기

            //예외는 프로그램실행 중 발생하는 오류입니다. 예외를 처리하면 프로그램이 중단되지않고
            //실행을 계속할수있습니다.
            //try catch 

            /* while (true)
             {

                 try
                 {
                     int[] numbers = { 1, 2, 3 };
                     Console.WriteLine(numbers[5]); //오류 발생
                 }
                 catch (IndexOutOfRangeException ex)
                 {
                     Console.WriteLine($"Error : {ex.Message}");
                 }
                 finally
                 {
                     Console.WriteLine("항상 실행됩니다.");
                 }
             }*/

            //Exception 클래스 
            //모든예외의 기본 클래스입니다.

            /*try
            {
                int number = int.Parse("abc");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error : {ex.Message}");
            }*/

            /*try
            {
                int age = -5;
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }*/

            /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            names.Add("Dave");
            names.Remove("Bob");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }*/

            /*List<int> list = new List<int>();

            for(int i = 0; i<3; i++)
            {
                list.Add(i+1);
                Console.WriteLine(list[i]);
            }
            list.Insert(0, 0);
            Console.WriteLine(list[0]);*/
            /*
                        List<int> list = new List<int>();

                        list.Add(1);
                        list.Add(2);
                        list.Add(3);

                        //foreach (int i in list)
                        //{
                        //    Console.WriteLine(i);
                        //}

                        //Console.WriteLine(list[1]);
                        //list.Insert(1, 100);
                        //Console.WriteLine(list[1]);

                        //Console.WriteLine(list[0]);

                        list.Insert(1, 100);
                        Console.WriteLine(list.Count);

                        list[2] = 200;
                        list.Remove(3);

                        foreach (int i in list)
                        {
                            Console.WriteLine(i);
                        }*/

            /*Stack<int> stack = new Stack<int>();

            for(int i = 0; i<3; i++)
            {
                stack.Push(i + 1);
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 3; i++)
            {
                queue.Enqueue(i);
            }

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }*/

            /*ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);

            Console.WriteLine("ArrayList");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Remove(1);

            foreach(var item in arrayList)
            {
                Console.Write("\n" + item); //hello 3.14 출력
            }*/

            /*//HashTable 클랙스
            //키-값 쌍을 저장하는 컬렉션
            //키를 이용해 값을 빠르게 검색
            Hashtable hash = new Hashtable();

            //키-값 쌍 추가
            hash["Alice"] = 25;
            hash["Bob"] = 30;
            hash["포션"] = 20;

            Console.WriteLine("HashTable요소");

            foreach(DictionaryEntry entry in hash)
            {
                Console.WriteLine($"Key : {entry.Key} || Value : {entry.Value}");
            }

            //특정 키의 값 가져오기
            Console.WriteLine("\n" + hash["Alice"]);

            //요소 제거
            hash.Remove("Bob");
            foreach (DictionaryEntry entry in hash)
            {
                Console.WriteLine($"Key : {entry.Key} || Value : {entry.Value}");
            }*/


            /*Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            Console.WriteLine($"CupOfString: {cupOfString.Content}");
            Console.WriteLine($"cupOfInt: {cupOfInt.Content}");*/

            /*Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave");


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }*/

            /*ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            IEnumerator enumerator = (IEnumerator)list.GetEnumerator();


            while (enumerator.MoveNext()) //다음 요소가 있는지 확인
            {
                Console.WriteLine(enumerator.Current);//현재 요소 출력
            }*/

            /*var collection = new SimpleCollection();

            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }*/

            /*Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["돌도끼"] = 1;

            foreach (var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/

            /*int? nullableInt = null;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            nullableInt = 10;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");*/

            /*string str = null;

            if (str == null)
            {
                Console.WriteLine("DefaultValue");
            }

            Console.WriteLine(str ?? "DefaultValue");//str이 null이면 "Default Value*/

            //LINQ는 확장메서드 형태로 제공된다. 
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

        }

        //클래스시그니처 기본구성
        //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

        //[접근 지정자] [수정자] class 클래스이름  : 부모클래스 , 인터페이스
        //public       abstract                  : BaseClass  ,IComparable
        //private      sealed
        //protected    static
        //             partial

        class Cup<T>
        {
            public T Content { get; set; }
        }


        //        IEnumerator를 사용하는 이유
        //✔ 컬렉션을 직접 제어하며 순회할 수 있음
        //✔ foreach 없이도 컬렉션 순회 가능
        //✔ LINQ나 커스텀 컬렉션을 만들 때 유용함
        /*public interface IEnumerator
        {
            bool MoveNext(); // 다음 요소로 이동 (이동할 요소가 있으면 true 반환)
            object Current { get; } // 현재 요소 반환
            void Reset(); // 처음 위치로 리셋
        }*/

        class SimpleCollection : IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach (var item in data)
                {
                    yield return item;
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }


        //기본클래스
        public class Player
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }
        //상속하는 클래스
        public class Warrior : Player
        {
            public int Strength { get; set; }
        }
        //인터페이스를 구현하는 클래스
        //public class Enemy: IAttackable, IMovable
        //{
        //    public void Attack() { }
        //    public void Move() { }

        //}
        //추상 클래스 (abstract)
        public abstract class Animal
        {
            public abstract void MakeSound();
        }
    }
}
