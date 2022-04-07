//https://programmers.co.kr/learn/courses/30/lessons/86051
//풀이시간 3분

using System;
using System.Linq;

public class Solution
{
    public int solution(int[] numbers)
    {
        return Enumerable.Range(1, 9).Except(numbers).Sum();
    }
}