//https://programmers.co.kr/learn/courses/30/lessons/82612
//풀이시간 8분

using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long need = 0;
        for (int i = 0; i < count; i++)
        {
            need += price * (i + 1L);
        }

        if (need < money) return 0;
        else return need - money;
    }
}