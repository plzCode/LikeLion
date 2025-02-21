using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("깃 허브 연결하기");*/

            /*
                        //변수 선언
                        int age;
                        age = 25;

                        Console.WriteLine(age);
            */

            /*
                        //리터럴 : 코드에서 고정된 값을 의미
                        int number = 10; //정수
                        double pi = 3.141592653589793238462643383; //실수
                        char letter = '한'; //문자
                        string name = "Tarnished"; //문자열

                        Console.WriteLine(number);
                        Console.WriteLine(pi);
                        Console.WriteLine(letter);
                        Console.WriteLine(name);
            */
            /*
                        float hp = 100.0f;
                        float att = 56.7f;
                        string name = "Tarnished";
                        char grade = 'S';

                        Console.WriteLine("캐릭터");
                        Console.WriteLine("체력 : " + hp);
                        Console.WriteLine("공격력 : " + att);
                        Console.WriteLine("이름 : " + name);
                        Console.WriteLine("등급 : " + grade);
            */

            /*
                        Character player = new Character(100.0f, 56.7f, "Tarnished", 's');
                        Console.WriteLine("캐릭터");
                        Console.WriteLine("체력 : " + player.hp);
                        Console.WriteLine("공격력 : " + player.att);
                        Console.WriteLine("이름 : " + player.name);
                        Console.WriteLine("등급 : " + player.grade);
            */

            /*
                        //문자열
                        string greeting; //문자열 변수를 선언
                        greeting = "Hello, World!";

                        //변수의 값을 사용
                        Console.WriteLine(greeting);//출력 Hello, World!
            */

            /*
                        //변수 선언과 함께 초기화
                        int score = 100;
                        double temperature = 36.5;
                        string city = "Daegu";

                        //변수 출력
                        Console.WriteLine(score);
                        Console.WriteLine(temperature);
                        Console.WriteLine(city);
            */
            /*
                        //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
                        int x = 10, y = 20, z = 30;

                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        Console.WriteLine(z);
            */

            /*
                        //const 키워드를 사용하면 값을 변경할 수 없는 상수를 선언
                        const double pi = 3.141592653589793238462643383;

                        Console.WriteLine("Pi : " + pi);
            */

            /*
                        LostArk_Character lostark_char = new LostArk_Character(16755, 78103, 36, 1017, 41, 611, 22, 39);

                        Console.WriteLine("공격력 : " + lostark_char.power);
                        Console.WriteLine("최대 체력 : " + lostark_char.max_hp);
                        Console.WriteLine("치명 : " + lostark_char.critical);
                        Console.WriteLine("특화 : " + lostark_char.specialization);
                        Console.WriteLine("제압 : " + lostark_char.overpower);
                        Console.WriteLine("신속 : " + lostark_char.fast);
                        Console.WriteLine("인내 : " + lostark_char.patience);
                        Console.WriteLine("숙련 : " + lostark_char.skilled);
            */

            /*
                        //숫자 데이터 형식 : 정수와 실수를 다룰 때 사용하는 다양한 타입
                        int integerNum = 10; //정수 데이터
                        float floatNum = 3.14f; //단정밀도 실수
                        double doubleNum = 3.141592653589793238462643383; //배정밀도 실수

                        Console.Write(integerNum + ", ");
                        Console.Write(floatNum + ", ");
                        Console.Write(doubleNum);
            */

            /*
            //정수 데이터 형식 : 소수점이 없는 숫자를 표현
            int intValue = -100; //4바이트 크기의 정수
            long longValue = 1234567890L; //8바이트 크기의 정수

            Console.WriteLine(intValue);
            Console.WriteLine(longValue);

            //부호 있는 정수 : 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50; //1바이트 크기
            short signedShort = -3200; //2바이트 크기
            int signedInt = -2000000000; //4바이트 크기

            Console.WriteLine(signedByte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedInt);
            */
            /*
                        //부호없는 정수 데이터 형식
                        byte unsignedByte = 255; //1바이트 크기
                        ushort unsignedShort = 65000; //2바이트 크기
                        uint unsignedInt = 4000000000; //4바이트 크기

                        Console.WriteLine(unsignedByte);
                        Console.WriteLine(unsignedShort);
                        Console.WriteLine(unsignedInt);
            */

            /*
                        //실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
                        float singlePrecision = 3.14f; //단정밀도 실수 (4바이트)
                        double doublePrecision = 3.1415926535897; //배정밀도 (8바이트)
                        decimal highPrecision = 3.141592653589793238462643383m; //고정밀도 (16바이트)

                        Console.WriteLine(singlePrecision);
                        Console.WriteLine(doublePrecision);
                        Console.WriteLine(highPrecision);
            */
            /*
                        // 접미사사용 : 숫자의데이터 형식을 명시
                        int integerValue = 100;     // 기본 정수형 (int)
                        long longValue = 100L;      // 정수형  (long)
                        float floatValue = 3.14f;   // 실수형 (float)
                        double doubleValue = 3.14;  // 기본 실수형 (double)
                        decimal decimalValue = 3.14m; // 고정밀도 실수형 (decimal)

                        Console.WriteLine(integerValue);
                        Console.WriteLine(longValue);
                        Console.WriteLine(floatValue);
                        Console.WriteLine(doubleValue);
                        Console.WriteLine(decimalValue);
            */
            /*
                        //char 형식 : 단일 문자를 표현
                        char letter = 'A'; //문자 a 저장
                        char symbol = '#'; //특수 기호 저장
                        char number = '9';

                        Console.WriteLine(letter);
                        Console.WriteLine(symbol);
                        Console.WriteLine(number);
            */
            /*
                        //string 형식 : 여러 문자를 저장
                        string greeting = "Hello World";
                        string name = "Alice";

                        Console.WriteLine(greeting);
                        Console.WriteLine(name);

                        Console.WriteLine(greeting + " " + name);
            */
            /*
                        //bool 형식 : 참(true) = 1 거짓 (false) = 0
                        bool isRunning = true; //프로그램 실행 상태
                        bool isFinished = false; //프로그램 종료 상태

                        Console.WriteLine(isRunning);
                        Console.WriteLine(isFinished);
            */
            /*
                        //const 변하지 않는 값을 정의
                        const double PI = 3.14159;
                        const int MAX_SCORE = 100; //최대 점수

                        Console.WriteLine(PI);
                        Console.WriteLine(MAX_SCORE);
            */
            /*
                        //닷넷형식 : 기본 형식의 닷넷 표현
                        System.Int32 number = 123; //int의 닷넷
                        System.String text = "Hello"; //string의 닷넷
                        System.Boolean flag = true; //bool의 닷넷

                        Console.WriteLine(number);
                        Console.WriteLine(text);
                        Console.WriteLine(flag);
            */
            /*
                        char num = '9';
                        Console.Write(num * 7);
            */
            /*
                        //int 래퍼 형식의 메서드 활용
                        int number = 123;
                        string numberAsString = number.ToString(); //정수 -> 문자열

                        //bool 래퍼 형식
                        bool flag = true;

                        string flagAsString = flag.ToString();//논리값 -> 문자열

                        Console.WriteLine(numberAsString);
                        Console.WriteLine(flagAsString);
            */
            

        }

        
    }
    struct LostArk_Character
    {
        public int power; //공격력
        public int max_hp; //최대체력
        public int critical; //치명
        public int specialization; //특화
        public int overpower; //제압
        public int fast; //신속
        public int patience; //인내
        public int skilled; //숙련
        public LostArk_Character(int power, int max_hp, int critical, int specialization, int overpower, int fast, int patience, int skilled)
        {
            this.power = power;
            this.max_hp = max_hp;
            this.critical = critical;
            this.specialization = specialization;
            this.overpower = overpower;
            this.fast = fast;
            this.patience = patience;
            this.skilled = skilled;
        }
    }

    struct Character
    {
        public float hp;
        public float att;
        public string name;
        public char grade;
        public Character(float hp, float att, string name, char grade)
        {
            this.hp = hp;
            this.att = att;
            this.name = name;
            this.grade = grade;
        }
    }
}
