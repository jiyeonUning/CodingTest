namespace Coding_Test
{
    internal class TestOne
    {
        // 정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 soltuion 함수를 완성해주세요.

        // 제한 사항
        // -50000 ≤ num1 ≤ 50000
        // -50000 ≤ num2 ≤ 50000

        public class Solution
        {
            public int solution(int num1, int num2)   // 정수 선언
            {
                int answer = 0;

                if (-50000 <= num1 && num1 <= 50000   // 제한 걸어주기
                 && -50000 <= num2 && num2 <= 50000)
                { answer = num1 - num2; }

                return answer;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
