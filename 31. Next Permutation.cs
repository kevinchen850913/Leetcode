//早期很爛的答案
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int k = -2;
        int j = 101;
        int l = 0;
        int[] num = nums;
        for (int i = num.Length - 1; i > 0; i--)
        {
            if (num[i] > num[i - 1])
            {
                k = i - 1;
                break;
            }
        }
        if (k == -2)
        {
            Array.Sort(num);
            return;
        }
        for (int i = k; i < num.Length; i++)
        {
            if (num[i] > num[k] && num[i] < j)
            {
                j = num[i];
                l = i;
            }
        }
        num[l] = num[k];
        num[k] = j;
        Array.Sort(num, k + 1, num.Length - k - 1);
        return;
    }
}