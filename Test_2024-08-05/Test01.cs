namespace Test_2024_08_05
{
    // 2024-08-05 코딩테스트 : https://school.programmers.co.kr/learn/courses/30/lessons/120806

    // < 두 수의 나눗셈 >
    // 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.

    // 제한사항 :
    // 0 < num1 ≤ 100
    // 0 < num2 ≤ 100

    public class Test01
    {
        public class Solution
        {
            public int solution(double num1, double num2)
            {
                double AAA = (num1 / num2) * 1000;
                int answer = (int)AAA;
                return answer;
            }
        }
    }
}
