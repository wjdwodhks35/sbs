using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            //1.이름 입력 받기
            string Name;
            Console.Write("이름 입력 : ");
            Name = Console.ReadLine();
            //2.생년 입력 받기
            string BirthYear;
            Console.Write("생년 입력 : ");
            BirthYear = Console.ReadLine();
            //3.자기소개 입력받기
            string Introduce;
            Console.Write("자기소개 입력 : ");
            Introduce = Console.ReadLine();
            //4.string으로 출력
            int Age;
            Console.WriteLine(Name);
            Age = 2023 - Convert.ToInt32(BirthYear) + 1;
            Console.WriteLine(Age);
            Console.WriteLine(Introduce);
            //5.$넣어서 표현
            Console.WriteLine($"{Name} {Age} {Introduce}");
            //6.@넣어서 사각형 만들기

            Console.WriteLine(@" ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
ㅣ		      ㅣ
ㅣ		      ㅣ
ㅣ		      ㅣ
ㅣ		      ㅣ
ㅣ		      ㅣ
ㅣ		      ㅣ
 ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            //7.1,2,3 string배열 넣기
            string[] str1 = new string[3] { Name, BirthYear, Introduce };
            //8. string 배열값을 4번과 같은 방식으로 출력하기
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Introduce);
            //9. string 배열값을 5번과 같은 방식으로 출력하기
            Console.WriteLine($"{Name} {Age} {Introduce}");

        }
    }
}
