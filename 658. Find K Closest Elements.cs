using System.Collections.Generic;
using System;

public class Solution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        IList<int> list = new List<int>();
        int i = 0;
        for (; i < arr.Length - k; i++)
        {
            if (Math.Abs(arr[i] - x) < Math.Abs(arr[i + k] - x))
                break;
        }
        while (i > 0 && Math.Abs(arr[i - 1] - x) == Math.Abs(arr[i + k - 1] - x))
        {
            i--;
        }
        for (int j = 0; j < k; j++)
        {
            list.Add(arr[i + j]);
        }
        return list;
    }
}