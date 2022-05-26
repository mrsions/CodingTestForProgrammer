//https://programmers.co.kr/learn/courses/30/lessons/12943
//풀이시간 40분
// 재귀 최적화에 신경쓰다보니 시간이 오버됨

using System;
using System.Collections.Generic;

public class Solution
{
    HashSet<int> result = new HashSet<int>();

    public int solution(string numbers)
    {
        char[] arr = numbers.ToCharArray();

        Collect(arr, 0, 0, arr.Length);

        int cnt = result.Count;

        foreach (var num in result)
        {
            for (int i = 2, len = num / 2 + 1; i < len; i++)
            {
                if (num % i == 0)
                {
                    cnt--;
                    break;
                }
            }
        }

        return cnt;
    }

    private void Collect(char[] arr, int v, int s, int end)
    {
        if (v > 1)
        {
            result.Add(v);
        }

        if (s != end)
        {
            for (int i = s; i < arr.Length; i++)
            {
                Swap(arr, i, s);
                Collect(arr, v * 10 + (arr[s] - '0'), s + 1, end);
                Swap(arr, i, s);
            }
        }
    }

    private void Swap(char[] arr, int a, int b)
    {
        var temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}