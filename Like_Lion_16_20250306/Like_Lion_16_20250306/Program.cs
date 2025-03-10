using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello; //네임스페이스를 사용 가능 using

namespace Like_Lion_16_20250306
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Say say = new Say();
            say.SayHello();*/
            /*Person p = new Person();
            *//*p.name = "Alice";
            Console.WriteLine(p.name);*//*
            p.SetName("Alice");
            Console.WriteLine(p.GetName());*/

            /* MyResouce r = new MyResouce();
             //GC에 의해 나중에소멸자 호출(garbage collector는 더이상 참조되지 않는 객체를 정리)

             int a = 10;
             Increase(ref a);
             Console.WriteLine(a);*/

            /*int a = 10;
            int b = 20;
            // Increase(ref a);
            // Console.WriteLine("A의 값 : " + a);
            int x, y;
            OutFunc(a, b, out x, out y);

            Console.WriteLine("x : " + x + "y : " + y);*/

            /*Animal myDog = new Dog();
            myDog.MakeSound(); //멍멍
            myDog.Sleep();

            Animal myCat = new Cat();
            myCat.MakeSound();
            myCat.Sleep();*/

            Child child = new Child("Alice", 178);
            
            
        }
        class Parent 
        {
            protected string name = "Unknown";
            public Parent()
            {
                Console.WriteLine("부모 생성자 호출");
            }
            public Parent(string name)
            {
                this.name = name;
                Console.WriteLine($"부모 생성자 : {name}");
            }

        }

       class Child : Parent
        {
            private int age;
            public Child()
            {
                Console.WriteLine("자식 생성자 호출");
            }
            //부모 생성자를 호출하면서 name 전달 + 추가로 age초기화
            public Child(string name, int age):base(name)
            {
                this.age = age;
                Console.WriteLine($"자식 생성자 {name} : 나이 = {age}");
            }
        }


        //추상클래스 (Abstract Class)?
        //추상클래스는 객체를 생성할수 없는 클래스로, 상속을 통해서만 사용할 수있습니다.
        //공통적인 기능을 정의하고, 상속받은 클래스가 이를 구현하도록 강제할때 사용됩니다.
        //abstract 키워드를 사용
        //추상 메서드는 선언만 하고, 구현은 하지 않습니다.
        //상속받은 클래스는 반드시 구현해야한다.
        abstract class Animal
        {
            //추상 메서드 (구현 x, 상속받은 클래스가 구현)
            public abstract void MakeSound();

            //일반 메서드(공통 기능 제공)
            public void Sleep()
            {
                Console.WriteLine("동물이 잠을 잡니다.");
            }
        }

        //추상 클래스를 상속받아 구체적인 클래스 구현
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("멍멍!");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("야옹!");
            }
        }



        static int Increase(ref int x)
        {
            return x++;
        }
        //out은 반환이 여러개일때 유용하다
        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }

    }



    class MyResouce
    {
        //소멸자
        ~MyResouce()
        {
            Console.WriteLine("삭제될 때 호출");
        }
    }

    class Person
    {
        private string name;

        public Person()
        {
            this.name = "UnKnown";
        }
        public Person(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
    }

}

namespace Hello
{
    public class Say 
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");

        }
    }


}
