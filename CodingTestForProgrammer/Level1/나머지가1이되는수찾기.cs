//https://programmers.co.kr/learn/courses/30/lessons/87389
//풀이시간 2분

using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int i = 1;
        while (n % i != 1)
        {
            i++;
        }
        return i;
    }
}