using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_8_20250228
{
    class Person
    {
        public string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"나이 : {age}");
        }
        
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
    }

    class Marine
    {
        string name;
        int cost;

        public Marine() 
        {
            this.name = "MARINE";
            this.cost = 50;
        }
        public Marine(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public string GetName()
        {
            return name;
        }
        public int GetCost()
        {
            return cost;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 코스트 : {cost}");
        }
    }

    class Scv
    {
        string name;
        int cost;

        public Scv() 
        {
            this.name = "SCV";
            this.cost = 50;
        }
        public Scv(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public string GetName()
        {
            return name;
        }
        public int GetCost()
        {
            return cost;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 코스트 : {cost}");
        }
    }

    class Barrack
    {
        string name;
        int cost;

        enum units
        {
            Marine,
            FireBat,
            Ghost,
            Medic
        }

        public Barrack()
        {
            name = "배럭";
            cost = 150;
        }
        public Barrack(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public void GenerateMarine()
        {

        }

        public string GetName()
        {
            return name;
        }
        public int GetCost()
        {
            return cost;
        }
    }
    class Mineral
    {
        public int MineralCount;

        public Mineral()
        {
            MineralCount = 1500;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : {MineralCount}");
        }
    }
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;
        public static int maxCharCount;

        public Game()
        {
            mineral = 0;
            gas = 0;
            charCount = 0;
            maxCharCount = 200;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral} 가스 : {gas} 인구수 : {charCount}/{maxCharCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time : {now}");

            TimeSpan duration = new TimeSpan(1, 30, 0);
            Console.WriteLine($"Duration : {duration}");*/

            /*Person person = new Person("홍길동", 20);

            Console.Write("이름은? : ");
            person.name = Console.ReadLine();

            person.ShowInfo();*/

            /*Marine marin = new Marine("불꽃테란", 100);
            Scv scv = new Scv("열받은SCV", 70);
            Barrack barrack = new Barrack(); 
            
            Mineral[] mineral = new Mineral[7];

            //각 배열에 new 객체화
            for (int i = 0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }


            marin.ShowInfo();

            scv.ShowInfo();*/
            
        }
    }
}
