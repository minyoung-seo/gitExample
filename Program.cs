using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Cal MyCal = new Cal();
            float Num1, Num2, Result = 0;
            string Sel;
                        
            
            while(true)
            {
                Console.WriteLine("두 수의 사칙연산 프로그램");
                Console.Write("첫번째 수 : ");
                Num1 = float.Parse(Console.ReadLine());
                Console.Write("두번째 수 : ");
                Num2 = float.Parse(Console.ReadLine());

                Console.Write("연산기호를 선택하세요. (+,-,*,/) : ");
                Sel = Console.ReadLine();

                if (Sel == "+")
                {
                    Result = MyCal.Plus(Num1, Num2);
                    Console.WriteLine("연산결과 : {0}", Result);
                }

                else if (Sel == "-")
                {
                    Result = MyCal.Minus(Num1, Num2);
                    Console.WriteLine("연산결과 : {0}", Result);
                }

                else if (Sel == "*")
                {
                    Result = MyCal.Mul(Num1, Num2);
                    Console.WriteLine("연산결과 : {0}", Result);
                }

                else if (Sel == "/")
                {
                    Result = MyCal.Div(Num1, Num2);
                    Console.WriteLine("연산결과 : {0}", Result);
                }
                else
                    Console.WriteLine("연산기호를 잘못 입력했습니다.");

                if (Sel == "END") break;
            }
        }
    }
}
