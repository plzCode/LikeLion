using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Like_Lion_9_20250228
{
    class Person
    {
        private string name; //내부 변수

        public string Name
        {
            get { return name; }
            set { name = value; }
        }//프로퍼티
            

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }

    class People
    {        
        public string name { get; set; } //자동 구현 프로퍼티
        public float balance { get; private set; } //외부 변경 불가
        private int count = 100;

        public int Count //읽기만 가능
        {
            get { return count; }
        }
        public void SetCount(int count)
        {
            this.count = count;
        }
       
        public void SetBalance(float balance)
        {
            this.balance = balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Person p1 = new Person();
            Console.Write("이름을 입력하세요 : ");
            p1.SetName(Console.ReadLine());

            Console.WriteLine($"이름은 {p1.GetName()}입니다.");

            Person p2 = new Person();
            p2.Name = p1.GetName();
            Console.WriteLine($"이름은 {p2.Name}입니다.");*/

            People pe1 = new People();
            pe1.name = "홍길운";
            

            pe1.SetBalance(10.0f);
            pe1.SetCount(1000);
            Console.WriteLine($"이름 : {pe1.name} 카운트 : {pe1.Count} 밸런스 : {pe1.balance}");

        }
    }
}
