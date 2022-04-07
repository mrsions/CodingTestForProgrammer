//https://programmers.co.kr/learn/courses/30/lessons/12943
//풀이시간 20분
// (손코딩하다보니 int 오버플로우를 발견하지 못했음.)

using System;

public class Solution
{
    public int solution(int num)
    {
        long val = num;
        for (int i = 0; i < 500; i++)
        {
            if (val == 1)
            {
                return i;
            }
            else if (val % 2 == 0)
            {
                val = val / 2;
            }
            else
            {
                val = val * 3 + 1;
            }
        }

        return -1;
    }
}