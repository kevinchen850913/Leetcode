//這是錯誤的答案，直接暴力破解，會超過規範時間。
using System.Collections.Generic;

public class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        int n;
        for (int i = 0; i < nums.Length; i++)
        {
            n = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                n += nums[j];
                n %= k;
                if (n == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}

//去參考別人的答案，先建立累進餘數表，
//若當前餘數在累進餘數表中出現過即為可整除。
public class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        if (nums == null || nums.Length < 2)
            return false;
        int prefixSum = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(0, -1);
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            int remainder = prefixSum % k;
            if (dic.ContainsKey(remainder) && i - dic[remainder] > 1)
                return true;
            else if (!dic.ContainsKey(remainder))
                dic.Add(remainder, i);
        }
        return false;
    }
}