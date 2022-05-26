//https://programmers.co.kr/learn/courses/30/lessons/42746?language=csharp
//풀이시간 ???
//0의 예외를 발견하지 못해서 오래걸림

using System;
using System.Text;
using System.Collections.Generic;

public class Solution
{
    private int Merge(int a, int b)
    {
        if (b < 10) a *= 10;
        else if (b < 100) a *= 100;
        else if (b < 1000) a *= 1000;
        else a *= 10000;

        return a + b;
    }

    public string solution(int[] numbers)
    {

        Array.Sort(numbers, (a, b) =>
        {
            return Merge(b, a).CompareTo(Merge(a, b));
        });

        if (numbers[0] == 0)
        {
            return "0";
        }

        StringBuilder v = new StringBuilder(numbers.Length * 3);
        foreach (var s in numbers) v.Append(s);

        return v.ToString();
    }
}