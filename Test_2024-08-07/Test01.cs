﻿namespace Test_2024_08_07
{
    internal class Test01
    {
        // 2024-08-07 코딩테스트 : https://school.programmers.co.kr/learn/courses/30/lessons/120810

        // < 나머지 구하기>
        // 정수 num1, num2가 매개변수로 주어질 때, num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.

        // 제한사항 : 
        // 0 < num1 ≤ 100
        // 0 < num2 ≤ 100

        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = num1 % num2;
                return answer;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
