//https://programmers.co.kr/learn/courses/30/lessons/77484
//풀이시간 7분

using System;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] answer = new int[] { };

        int unkownNumbers = 0;
        int matchNumbers = 0;

        for (int i = 0; i < lottos.Length; i++)
        {
            int num = lottos[i];
            if (num == 0)
            {
                unkownNumbers++;
            }
            else
            {
                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (win_nums[j] == num)
                    {
                        matchNumbers++;
                        break;
                    }
                }
            }
        }

        return new int[]
        {
            Math.Min(6, 7 - matchNumbers - unkownNumbers),
            Math.Min(6, 7 - matchNumbers)
        };
    }
}