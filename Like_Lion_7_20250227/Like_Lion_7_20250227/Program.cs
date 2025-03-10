using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dev1
{
    class MyClass 
    {
        public static void SayHello()
        {
            Console.WriteLine("개발 1팀입니다");
        }
    } 
}

namespace Like_Lion_7_20250227
{
    class Program
    {
        /*
        열거형이란?
        Enumeration enum
        숫자 값에 이름을 부여하는 자료형
        가독성을 높이고 의미 있는 값으로 표현 가능
        기본적으로 첫 번째 값은 0부터 시작해서 1씩 증가
        */

        //기본 enum사용법
        enum DayOfWeek
        {
            Sunday, //0
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }
        
        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        struct Point
        {
            //public 어디서든 사용 가능하게 권한
            //private 해당 지역에서만 사용 가능

            public int x;
            public int y;
            public Point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }

            public void Print()
            {
                Console.WriteLine($"좌표 : {x} , {y}");
            }
        }

        struct Rectangle
        {
            public int width;
            public int height;

            public int GetArea()
            {
                return width * height;
            }
        }

        struct Score
        {
            public string name;
            public int korean;
            public int english;
            public int math;

            public Score(string _name, int _korean, int _english, int _math)
            {
                name = _name;
                korean = _korean;
                english = _english;
                math = _math;
            }

            public void Print_Score()
            {
                Console.WriteLine($"{name}\t{korean}\t{english}\t{math}");
            }
        }

        static int num_static = 10;

        //최대 아이템 개수
        const int MAX_ITEMS = 10;

        //아이템 배열
        static string[] itemNames = new string[MAX_ITEMS];
        static int[] itemCounts = new int[MAX_ITEMS];

        static void AddItem(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name) //이미 있는 아이템이라면 갯수 증가
                {
                    itemCounts[i] += count;
                    return;
                }
            }
            for(int i = 0; i<MAX_ITEMS; i++)
            {
                if (itemNames[i] == null)
                {
                    itemNames[i] = name;
                    itemCounts[i] = count;
                    return;
                }
            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }

        static void RemoveItem(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemCounts[i] >= count) //개수가 충분하면 차감
                {
                    itemCounts[i] -= count;
                    if (itemCounts[i] == 0) //개수가 0이면 삭제
                    {
                        itemNames[i] = null;
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("아이템 개수가 부족합니다!");
                    return;
                }
            }
            Console.WriteLine("아이템을 찾을 수 없습니다!");
        }
        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] != null)
                {
                    Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }

        struct Position
        {
            public int X;
            public int Y;

            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        struct Player
        {
            public Position Pos;
            public string[] Shape;

            public Player(int x, int y, string[] shape)
            {
                Pos = new Position(x, y);
                Shape = shape;
            }

            public void Move(int dx, int dy)
            {
                Pos.X += dx;
                Pos.Y += dy;
            }
        }

        struct Missile
        {
            public Position Pos;
            public bool IsActive;
            public string shape;

            public Missile(int x, int y, string shape)
            {
                Pos = new Position(x, y);
                IsActive = true;
                this.shape = shape;
            }

            public void Shot()
            {
                if (IsActive)
                {
                    Pos.X++; // 오른쪽으로 이동
                    if (Pos.X >= Console.WindowWidth) // 화면 끝 도달 시 비활성화
                    {
                        IsActive = false;
                    }
                }
            }
        }

        struct Inventory
        {
            public string itemName;
            public int itemCount;
        }

        static void AddItem(Inventory[] inv, string name, int count)
        {
            if (count < 0) return;
            for(int i = 0; i<inv.Length; i++)
            {
                if (inv[i].itemName == "" || inv[i].itemName == name)
                {
                    inv[i].itemName = name;
                    inv[i].itemCount += count;
                    return;
                }
            }
            Console.WriteLine("빈 공간이 없습니다.");
        }

        static void RemoveItem(Inventory[] inv, string name, int count)
        {
            if (count < 0) return;
            for (int i = 0; i < inv.Length; i++)
            {
                if (inv[i].itemName == name)
                {
                    if (inv[i].itemCount < count)
                    {
                        Console.WriteLine("그만한 아이템이 없습니다.");
                        return;
                    }
                    inv[i].itemCount -= count;
                    if (inv[i].itemCount <= 0)
                    {
                        inv[i].itemName = "";
                        inv[i].itemCount = 0;
                    }
                    return;
                }
                
            }
            Console.WriteLine("빈 공간이 없습니다.");
        }

        static void ShowInventory(Inventory[] inv)
        {
            for(int i = 0; i<inv.Length; i++)
            {
                if (inv[i].itemName != "")
                {
                    Console.WriteLine($"{inv[i].itemName} : {inv[i].itemCount}개");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            
            Inventory[] playerInv = new Inventory[MAX_ITEMS];

            for(int i = 0; i < playerInv.Length; i++)
            {
                playerInv[i].itemName = "";
                playerInv[i].itemCount = 0;
            }

            while (true)
            {
                Console.Clear();
                int tmp = 0;
                try
                {
                    ShowInventory(playerInv);
                    Console.Write("무엇을 하시겠습니까? (1.아이템 추가, 2.아이템 제거) : ");
                    tmp = int.Parse(Console.ReadLine());
                    string itemName = "";
                    int itemNum = 0;
                    switch (tmp)
                    {
                        case 1:
                            Console.Write("추가 할 아이템이 무엇인가요? : ");
                            itemName = Console.ReadLine();
                            Console.Write("몇개나 추가하시나요? : ");
                            itemNum = int.Parse(Console.ReadLine());
                            AddItem(playerInv, itemName, itemNum);
                            Console.WriteLine($"{itemName}을 {itemNum}만큼 추가했습니다.");
                            break;

                        case 2:
                            Console.Write("무슨 아이템을 제거하시나요? : ");                            
                            itemName = Console.ReadLine();
                            Console.Write("몇개나 제거하시나요? : ");
                            itemNum = int.Parse(Console.ReadLine());
                            RemoveItem(playerInv, itemName, itemNum);
                            Console.WriteLine($"{itemName}을 {itemNum}만큼 제거했습니다.");
                            break;
                        default: 
                            Console.WriteLine("제대로 된 동작이 아닙니다.");
                            break;
                    }

                    Console.Read();
                }
                catch 
                { continue; }
            }


            /*PrintHello();
            PrintMessage("안녕하세요.");
            */
            /*int num = 20;
            Greet();
            Greet("철수");

            Console.WriteLine(Multiply(10, 20));
            Console.WriteLine(Multiply(10.1, 20.2));
            Increase(ref num);
            Console.WriteLine(num);
            Console.WriteLine(Sum(num,30,40,40));
            Console.WriteLine(Factorial(3));

            Console.WriteLine();
            dev1.MyClass.SayHello();
            SayHello();
            AddArrow(5, 3);

            Console.WriteLine();
            Console.WriteLine($"Pi: {Math.PI}");
            Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            Console.WriteLine($"Power (2^3) : {Math.Pow(2, 3)}");
            Console.WriteLine($"Round(3.75) : {Math.Round(3.75)}");

            Console.WriteLine();
            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine(today);
            Console.WriteLine((int)today);

            Console.WriteLine();
            StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);
            Console.WriteLine((int)status);*/

            //문제
            //열거형과 함수를 이용해서 풀어주세요.
            //Weapontype.Sword 검을 선택했습니다.
            //Weapontye.BOw 활을 선택했습ㄴ다.

            /*WeaponType wpType = new WeaponType();

            wpType = ChooseWeapon();

            Console.WriteLine($"{wpType}을 선택했습니다.");

            ChooseWeapon(wpType);*/

            /*Point p; //구조체 선언(초기화 필요)
            p.x = 3;
            p.y = 5;

            p.Print();

            Point q = new Point(10, 20);

            q.Print();*/

            /*var rect = new Rectangle { width = 5, height = 10 };
            Console.WriteLine($"Area : {rect.GetArea()}");*/

            /*Point[] points = new Point[2];

            for(int i = 0; i<points.Length; i++)
            {
                points[i].x = i;
                points[i].y = i * 2;
                Console.WriteLine($"point{i} X : {points[i].x}, point{i} Y : {points[i].y}");
            }*/


            /*int num = 0;

            Console.Write("학생의 수를 입력하세요 : ");
            num = int.Parse(Console.ReadLine());

            Score[] scores = new Score[num];

            for (int i = 0; i<num; i++) 
            {
                Console.WriteLine();

                Console.Write($"{i + 1}번 학생의 이름을 입력하세요 : ");
                scores[i].name = Console.ReadLine();

                Console.Write($"{scores[i].name}학생의 국어 점수를 입력하세요 : ");
                scores[i].korean = int.Parse(Console.ReadLine());
                Console.Write($"{scores[i].name}학생의 영어 점수를 입력하세요 : ");
                scores[i].english = int.Parse(Console.ReadLine());
                Console.Write($"{scores[i].name}학생의 수학 점수를 입력하세요 : ");
                scores[i].math = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine($"이름\t국어\t영어\t수학");
            for(int i= 0; i<num; i++)
            {
                scores[i].Print_Score();
            }*/

            /*//테스트 : 아이템 추가
            AddItem("포션", 5);
            AddItem("칼", 1);
            AddItem("포션", 3); //포션 개수 추가

            ShowInventory();

            //아이템 사용
            Console.WriteLine("포션 2개 사용");
            RemoveItem("포션", 2);
            ShowInventory();

            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            RemoveItem("방패", 1);

            ShowInventory();


            //테스트: 모든 포션 제거
            Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
            RemoveItem("포션", 6);
            ShowInventory();*/

            /*//미사일 쏘기
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            Console.WriteLine("콘솔 창 크기가 80x25로 설정되었습니다.");
            Console.ReadKey(); // 키 입력 대기

            ConsoleKeyInfo keyInfo;
            bool gameOver = false;
            Position playerPos = new Position(0,  Console.WindowHeight / 2);
            string[] playerShape = new string[] { "->", ">>>", "->" };
            string missileShape = ">>";
            int missileNum = 5;
            
            Player player = new Player(playerPos.X,playerPos.Y, playerShape);

            Missile[] missiles = new Missile[missileNum];

            for(int i = 0; i < missiles.Length; i++)
            {
                missiles[i].shape = missileShape;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSectond = stopwatch.ElapsedMilliseconds;

            while (!gameOver)
            {

                long currentSecond = stopwatch.ElapsedMilliseconds;
                if(currentSecond - prevSectond <= 100) //0.1초 루프
                {
                    continue;
                }
                
                Console.Clear();

                for (int i = 0; i < missileNum; i++)
                {
                    if (missiles[i].IsActive)
                    {
                        if (missiles[i].Pos.X + 1 <= Console.WindowWidth - 1)
                        {
                            Console.SetCursorPosition(missiles[i].Pos.X+1, missiles[i].Pos.Y+1);
                            Console.Write(missiles[i].shape);
                            missiles[i].Shot();
                        }
                        else
                        {
                            missiles[i].IsActive = false;
                        }
                    }
                }


                    //현재 위치 출력
                    for (int i = 0; i < player.Shape.Length; i++)
                    {
                        Console.SetCursorPosition(player.Pos.X, player.Pos.Y + i);
                        Console.WriteLine(player.Shape[i]);
                    }
                

                //키 입력 받기, 화면출력x
                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (player.Pos.Y > 0) player.Pos.Y--; break;
                    case ConsoleKey.DownArrow: if (player.Pos.Y < Console.WindowHeight - 3) player.Pos.Y++; break;
                    case ConsoleKey.LeftArrow: if (player.Pos.X > 0) player.Pos.X--; break;
                    case ConsoleKey.RightArrow: if (player.Pos.X < Console.WindowWidth - 3) player.Pos.X++; break;
                    case ConsoleKey.Spacebar: 
                        FireMissile(missileNum, missiles, player.Pos.X, player.Pos.Y);
                        break;
                    case ConsoleKey.Escape: return; //esc로 종료
                }

            }*/

        }

        static void FireMissile(int missileNum, Missile[] missiles, int x, int y)
        {
            for (int i = 0; i < missileNum; i++)
            {
                if (!missiles[i].IsActive) // 활성화된 미사일 찾기
                {
                    missiles[i] = new Missile(x+ 2, y, ">>"); // 오른쪽으로 발사
                    break; // 한 번에 하나의 미사일만 발사
                }
            }
        }

        static WeaponType ChooseWeapon()
        {
            Console.WriteLine("무기를 선택해 주세요(1.검 2.활 3.스태프) :");
            return (WeaponType)int.Parse(Console.ReadLine())-1;
        }
        static void ChooseWeapon(WeaponType weapon)
        {
            switch ((int)weapon)
            {
                case 0:
                    Console.WriteLine("검을 선택했습니다.");
                    break;
                case 1:
                    Console.WriteLine("활을 선택했습니다.");
                    break;
                case 2:
                    Console.WriteLine("스태프을 선택했습니다.");
                    break;
            }
        }

        static void SayHello()
        {
            Console.WriteLine("테스트 함수입니다.");
        }

        //화살표 함수
        static int AddArrow(int a, int b) => a + b;

        //재귀함수
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        //Param키워드(가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        //포인터
        static void Increase(ref int a)
        {
            a++;
        }

        //함수 오버로딩
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요.");
            

        }
        static void PrintMessage(string str)
        {
            Console.WriteLine(str);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
