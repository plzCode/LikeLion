using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Console.Write("이름을 입력하세요: ");
                        string userName = Console.ReadLine();//사용자로부터 입력을 받음

                        Console.WriteLine($"안녕하세요, {userName}님!");
            */
            /*
                        //문자열을 정수로 변환
                        Console.Write("나이를 입력하세요 : ");
                        string input = Console.ReadLine(); //사용자로부터 입력 받음
                        int age = int.Parse(input);
                        Console.WriteLine($"내년에는 {age+1}살이 되겠군요");//변환된 값을 사용
                        Console.WriteLine(age + 1 + " 메롱");
                        Console.WriteLine("내년에는 {0}살이 되겠군요",age+1);
                        Console.WriteLine("내년에는 " + age + 1 + " 살이 되겠군요!");//문자열로 시작할 시 뒤에나온 int도 문자열로 인식해 입력값이 a일때 a+1이 아닌 a1이 출력됨
            */

            string[] stats = 
                { 
                "루인 스킬 피해", 
                "카드 게이지 획득량", 
                "각성기 피해", 
                "최대 마나", 
                "전투 중 마나 회복량", 
                "비전투 중 마나 회복량", 
                "이동속도", 
                "탈 것 속도", 
                "운반 속도", 
                "스킬 재사용 대기시간 감소" 
            };
            List<string> inputStats = new List<string>();

            for (int i = 0; i < stats.Length; i++)
            {
                Console.Write(stats[i] + "를 입력하세요 : ");
                string tmp = Console.ReadLine();
                inputStats.Add(tmp);
            }
            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("");
            for(int i = 0; i<stats.Length; i++)
            {
                string suffix = "";
                if (float.TryParse(inputStats[i], out float result) && inputStats[i].Contains("."))
                {
                    suffix = "%";
                }
                Console.WriteLine(stats[i] + " : " + inputStats[i] + suffix);
            }

        }
    }
}
