using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Like_Lion_14_20250305
{
    class Program
    {
        public class Animal
        {
            public string name { get; set; }

            public virtual void Speak()
            {
                Console.WriteLine($"{name}(이)가 동물이 소리를 냅니다.");
            }
        }

        public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("멍멍");
            }
            public void Bark()
            {
                Console.WriteLine("왈왈!");
            }
            public void WagTail()
            {
                Console.WriteLine("꼬리를 흔든다.");
            }
        }

        public class Parents
        {
            public virtual void ShowMessage()
            {
                Console.WriteLine("부모 클래스 메세지");   
            }
        }

        public class Child : Parents
        {
            public override void ShowMessage()
            {
                Console.WriteLine("자식 클래스 메세지");
                base.ShowMessage();
            }
        }

        public class Job
        {
            public string name { get; set; }

            public Job()
            {
                name = "직업";
                Console.WriteLine($"{name}은");
            }
            public virtual void Show()
            {
                Console.WriteLine(name);
            }
        }


        public class Wizarrd : Job
        {
            public Wizarrd()
            {
                name = "위자드";
                Console.WriteLine($"{name}입니다.");
            }

        }

        public class Unit
        {
            public string name;
            public int health;

            public Unit()
            {
                name = "Unknown";
            }

            public virtual void Attack()
            {
                Console.WriteLine($"{name}이 공격합니다.");
            }
            public virtual void Heal(Unit unit)
            {
                Console.WriteLine($"{name}의 체력이 {health}가 되었다.");
            }
            public virtual void Move()
            {
                Console.WriteLine($"{name}이 이동.");
            }

        }

        class SCV : Unit
        {
            public SCV()
            {
                name = "SCV";
                health = 60;
            }

            public override void Attack()
            {
                Console.WriteLine("SCV가 용접기로 공격합니다.! (공격력이 약함)");
            }


            public override void Heal(Unit target)
            {
                Console.WriteLine($"SCV가 {target.name}을 수리합니다.(기계유닛만 가능)");
            }
        }
        class Marine : Unit
        {
            public Marine()
            {
                name = "Marine";
                health = 40;
            }

            public override void Attack()
            {
                Console.WriteLine("Marine이 소총으로 공격합니다.");
            }
        }
        class Medic : Unit
        {
            public Medic()
            {
                name = "Medic";
                health = 50;
            }

            public override void Heal(Unit target)
            {
                Console.WriteLine($"Medic이 {target.name}을 치료합니다. (생명유닛만가능)");
            }
        }
        class Tank : Unit
        {
            public Tank()
            {
                name = "Tank";
                health = 150;

            }

            public override void Attack()
            {
                Console.WriteLine("Tank가 시즈 모드로 강력한 포격!");
            }


            public override void Move()
            {
                Console.WriteLine("탱크가 천천히 움직입니다.");
            }

        }

        class Skill
        {
            public string Name; //스킬 이름
            public int ManaCost; //마나 소모량
            public int Cooldown; //재사용 대기 시간(밀리초)
            public int LastUsedTime; //마지막 사용 시간 (TickCount 기준)

            public Skill(string name, int manaCost, int cooldown)
            {
                Name = name;
                ManaCost = manaCost;
                Cooldown = cooldown * 1000; //초를 밀리초로 변환
                LastUsedTime = 0; //처음엔 사용하지 않은 상태
            }

            //스킬 사용 가능 여부 확인
            public bool CanUse(int playerMana)
            {
                int currentTime = Environment.TickCount;

                if (playerMana < ManaCost)
                {
                    Console.WriteLine($" 마나가 부족합니다! (필요 MP: {ManaCost}");
                    return false;
                }

                if (currentTime - LastUsedTime < Cooldown)
                {
                    int remainingTime = (Cooldown - (currentTime - LastUsedTime)) / 1000;
                    Console.WriteLine($" {Name} 스킬은 아직 사용할 수 없습니다.(남은 시간 : {remainingTime}초)");
                    return false;
                }

                return true;
            }


            //스킬 사용
            public void Use(ref int playerMana)
            {
                if (!CanUse(playerMana)) return;

                playerMana -= ManaCost; //플레이어마나 참조로 외부 값도 같이 조정 동기화
                LastUsedTime = Environment.TickCount; //현재 시간을 저장

                Console.WriteLine($"{Name} 스킬 사용! (MP - {ManaCost})");

            }
        }

        static void Main(string[] args)
        {
            /*List<Unit> units = new List<Unit>();

            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());


            //모든 유닛을 순회하며 다형성 적용
            foreach (var unit in units)
            {
                unit.Move(); //이동
                unit.Attack(); //공격
                Console.WriteLine();
            }


            //SCV가 탱크 수리 시도
            SCV scv = new SCV();
            scv.Heal(units[3]); //탱크 수리

            //Medic이 Marince 치료시도
            Medic medic = new Medic();

            medic.Heal(units[1]); //Marine을 치료*/

            int playerMana = 200; //플레이어의 초기 마나

            //스킬 목록 (배열 사용)
            Skill[] skills = new Skill[]
            {
                new Skill("파이어볼",20,3),  //마나 20, 소모, 3초 쿨다운 
                new Skill("얼음창",15,2),    //마나 15, 소모, 2초 쿨다운 
                  new Skill("힐링",30,5)    //마나 30, 소모, 5초 쿨다운 
            };



            while (true)
            {
                Console.Clear();
                Console.WriteLine($"현재 MP: {playerMana}");
                Console.WriteLine("사용 가능한 스킬: ");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {skills[i].Name} (MP {skills[i].ManaCost} " +
                        $",쿨다운 {skills[i].Cooldown / 1000}s)");
                }
                Console.WriteLine("0.종료");
                Console.Write("사용할 스킬 번호를 입력하세요: ");


                try
                {
                    int skillIndex = int.Parse(Console.ReadLine());

                    if (skillIndex == 0) break;

                    if (skillIndex > 0 && skillIndex <= skills.Length)
                    {
                        skills[skillIndex - 1].Use(ref playerMana);
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
                catch
                {
                    Console.WriteLine("숫자를 입력하세요!");
                }

                Thread.Sleep(500); //CPU과부화 방지

            }
            Console.WriteLine("게임종료");

            /* Wizarrd wiz = new Wizarrd();
             wiz.Show();*/


            /*Animal animal = new Animal();
            animal.name = "일반동물";
            animal.Speak();

            Dog dog = new Dog();
            dog.name = "말티즈";
            dog.Speak();*/

            //업캐스팅(Upcasting)
            //자식 클래스->부모클래스로 변환하는것
            //암시적 변환이 가능(컴파일러가 자동변환)
            //안전: 데이터 손실 없이 변환가능
            /*Dog myDog = new Dog(); //자식 클래스 객체 생성
            myDog.name = "말티즈"; 
            Animal myAnimal = myDog; //업캐스팅 (child -> parents)

            myAnimal.Speak();//사용가능 자식객체의 멍멍이 출력됨.
            *//*myAnimal.Bark(); //오류 업캐스팅 후 자식 클래스의 메서드는 접근 불가*/

            /*Animal myAnimal = new Dog();//업캐스팅
            Dog myDog = (Dog)myAnimal; //다운캐스팅 (명시적 변환)

            myDog.Bark();

            Animal myAnimal2 = new Animal();
            //Dog myDog2 = (Dog)myAnimal2; //안됨 

            if(myAnimal is Dog myDog2)
            {
                myDog2.Bark();
            }
            else
            {
                Console.WriteLine("변환할 수 없습니다.");
            }*/

            /*Animal myAnimal = new Dog();//업캐스팅
            myAnimal.Speak();//자식(Dog)의 오버라이드 된 메서드 실행
            Dog d = (Dog)myAnimal;
            d.WagTail();*/


            /*Child child = new Child();

            child.ShowMessage();*/

        }
    }
}
