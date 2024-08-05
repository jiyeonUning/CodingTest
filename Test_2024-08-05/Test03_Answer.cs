namespace Test_2024_08_05
{
    // 2024-08-05 코딩테스트 : https://school.programmers.co.kr/learn/courses/30/lessons/120808

    // < 분수의 덧셈 >
    // 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1, 두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다.
    // 두 분수를 더한 값을 기약 분수로 나타냈을 때 분자와 분모를 순서대로 담은 배열을 return 하도록 solution 함수를 완성해보세요.

    // 제한사항 : 
    // 0 <numer1, denom1, numer2, denom2 < 1,000

    // 혼자 힘으로 해결하지 못했으므로, 아래 다른 개발자분의 풀이를 달아둡니다.
    internal class Test03_Answer
    {
        public class Solution
        {
            public int[] solution(int denum1, int num1, int denum2, int num2)
            {
                int[] answer = new int[2];

                int a = 0;
                if (num1 % num2 == 0 || num2 % num1 == 0)
                {
                    if (num1 > num2)
                    {
                        answer[0] = denum1 + denum2 * num1 / num2;
                        answer[1] = num1;

                    }
                    else if (num1 < num2)
                    {
                        answer[0] = denum2 + denum1 * num2 / num1;
                        answer[1] = num2;
                    }
                    else
                    {
                        answer[0] = denum1 + denum2;
                        answer[1] = num1;
                    }
                }

                else
                {
                    answer[0] = num1 * denum2 + num2 * denum1;
                    answer[1] = num1 * num2;
                }

                //=======================================================

                if (answer[0] < answer[1])
                {
                    a = answer[1];
                }
                else
                {
                    a = answer[0];
                }

                //=========================================================

                for (int i = a; i > 0; i--)
                {
                    if (answer[1] % i == 0 && answer[0] % i == 0)
                    {
                        answer[1] /= i;
                        answer[0] /= i;
                    }
                }

                return answer;
            }
        }

    }
}
