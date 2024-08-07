namespace Test_2024_08_07
{
    internal class Test02
    {
        // 2024-08-07 코딩테스트 : https://school.programmers.co.kr/learn/courses/30/lessons/120811

        // < 중앙값 구하기 >
        // 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다.
        // 예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다.
        // 정수 배열 array가 매개변수로 주어질 때, 중앙값을 return 하도록 solution 함수를 완성해보세요.

        // 제한사항 : 
        // array의 길이는 홀수입니다.
        // 0 < array의 길이 < 100
        // -1,000 < array의 원소 < 1,000

        public class Solution
        {
            public int solution(int[] array)
            {
                Array.Sort(array);                    // 배열을 오름차순으로 정리하는 함수 Sort
              int answer = array[array.Length / 2];   // 전체 길이에서 반으로 나누고,
                                                      // 반으로 나눈 배열 중 가장 앞에 있는 수를 answer에 반환.       

               // 배열이 짝수갯수일 것을 대비하여, if문을 사용해 짝수일 경우의 식을 작성해준다. (출처 : 프로그래머스 하나두 개발자님)
               // if (array.Length % 2 == 0) answer = array[(array.Length / 2) - 1];

                return answer;
            }
        }
    }
}
