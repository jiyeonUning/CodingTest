﻿namespace Test_2024_08_05
{
    // 2024-08-05 코딩테스트 : https://school.programmers.co.kr/learn/courses/30/lessons/120807

    // < 숫자 비교하기 >
    // 정수 num1과 num2가 매개변수로 주어집니다. 두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.

    // 제한사항 : 
    // 0 ≤ num1 ≤ 10,000
    // 0 ≤ num2 ≤ 10,000

    internal class Test02
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = 0;

                if (num1 == num2)
                {
                    answer++;
                }
                else
                {
                    answer--;
                }

                return answer;
            }
        }
    }
}
