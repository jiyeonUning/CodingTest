namespace Test_2024_08_05
{
    // 2024-08-05 코딩테스트 : https://school.programmers.co.kr/learn/courses/30/lessons/120808

    // < 분수의 덧셈 >
    // 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1, 두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다.
    // 두 분수를 더한 값을 기약 분수로 나타냈을 때 분자와 분모를 순서대로 담은 배열을 return 하도록 solution 함수를 완성해보세요.

    // 제한사항 : 
    // 0 <numer1, denom1, numer2, denom2 < 1,000

    internal class Test03
    {
        // 스스로 작성한 코드
        static int[] solution(int numer1, int denom1, int numer2, int denom2)
        {
            int denominator = 0;
            if (denom1 > denom2)
            {
                denom1 = denominator;
            }
            else if (denom2 > denom1)
            {
                denom2 = denominator;
            }

            for (int i = 0; denom1 != denom2; i++)
            {
                if (denom1 == denom2)
                {
                    break;
                }
                else if (denom1 > denom2)
                {
                    int A = denom2 * i;
                    int B = numer2 * i;
                    A = denom2;
                    B = numer2;
                }
                else if (denom1 < denom2)
                {
                    int A = numer1 * i;
                    int B = denom1 * i;
                    A = numer1;
                    B = denom1;
                }
            }
            int numerator = numer1 + numer2;

            int[] answer = new int[] { numerator, denominator };

            return answer;
        }

        static void Main()
        {
            Console.WriteLine("첫번째 값을 입력하세요 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("두번째 값을 입력하세요 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("세번째 값을 입력하세요 : ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("네번째 값을 입력하세요 : ");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"결과는 다음과 같습니다 : {solution(num1, num2, num3, num4)}");
        }
    }
}
