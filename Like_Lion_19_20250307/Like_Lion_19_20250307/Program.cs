using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_19_20250307
{
    class Program
    {
        //Delegate 정의 - 메시지 출력을 위한 메서드 참조
        //string 매개변수를 받고 반환값이 없는 (void )메서드를 참조할 수 있는 타입

        delegate void MessageHandler(string message);

        //델리게이트에 연결할 메서드
        //메서드 형식과 타입이 일치해야 받아줌(위 델리게이트는 void형에 string형 변수를 인자로 받으니까 아래처럼 선언)
        static void DisplayMessage(string message) 
        {
            Console.WriteLine($"메세지 : {message}");
        }
        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"메세지 업 : {message.ToUpper()}");
        }

        class Character
        {
            public string name { get; private set; }
            public int health { get; private set; }

            /*이벤트 정의 - 캐릭터가 대미지르 입었을 때 발생
             EventHandler는 C#에서 제공하는 기본 델리게이트 타입
            이벤트는 외부에서 직접 호출할 수 없고 +=와 -= 연산자로만 접근 가능*/

            public event EventHandler onDamaged;

            public Character(string name, int health)
            {
                this.name = name;
                this.health = health;
            }

            public void TakeDamage(int amount)
            {
                health -= amount;
                Console.WriteLine($"{name}이 {amount}의 피해를 입었습니다. 남은 체력 : {health}");
                /*이벤트 발생 (구독자가 있는 경우에만)
                 ?. 연산자는 OnDamaged가 null이 아닐 때만 Invoke 메서드 호출
                EventArgs.Empty는 추가 데이터가 없을 때 사용하는 빈 이벤트 인자*/
                onDamaged.Invoke(this, EventArgs.Empty);
            }
        }
        /*이벤트 핸들러 메서드
        EnvenHandler 델리게이트와 일치하는 시그니처를 가져야함
        sender : 이벤트를 발생시킨 객체 (여기서는 Character객체)
        e: 이벤트와 관련된 추가 데이터(여기서는 사용x)*/

        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            Character character = (Character)sender;
            Console.WriteLine($"이벤트 알림 : {character.name}이 데미지를 입었습니다. \n현재 남은 체력 : {character.health}");
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine("====간단한 델리게이트와 이벤트 예제====");

            //1. 델리게이트 사용해보기
            Console.WriteLine("델리게이트1");

            //델리게이트 변수 선언 및 메서드 연결
            //DisplayMessage 메서드를 messageHandler 변수에 할당
            MessageHandler messageHandler = DisplayMessage;

            //델리게이트 호출 - 연결된 메서드가 실행됨
            messageHandler("안녕하세요");

            //델리게이트에 다른 메서드 추가(멀티 캐스트 델리게이트)
            //+=연산자로 메서드 추가
            messageHandler += DisplayUpperMessage;

            //여러 메서드가 연결된 델리게이트 호출됨
            //등록된 모든 메서드가 순서대로 호출됨
            Console.WriteLine("여러 메서드 호출");
            messageHandler("Hello ");

            //등록된 메서드 제거
            messageHandler -= DisplayMessage;

            messageHandler("hi");*/

            //캐릭터 생성
            Character hero = new Character("용사", 100);
            //이벤트 구독
            hero.onDamaged += Hero_OnDamaged;
            //데미지 입히기
            hero.TakeDamage(30);
        }
    }
}
