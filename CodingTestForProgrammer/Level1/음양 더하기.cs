//https://programmers.co.kr/learn/courses/30/lessons/76501
//풀이시간 3분

using System;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 0;
        for (int i = 0, len = absolutes.Length; i < len; i++)
        {
            if (signs[i])
            {
                answer += absolutes[i];
            }
            else
            {
                answer -= absolutes[i];
            }
        }
        return answer;
    }
}