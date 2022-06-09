public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] n = { 0, 0 };
        int k = 0;
        for (; k < nums.Length; k++)
        {
            if (nums[k] >= target / 2)
            {
                break;
            }
        }
        for (int i = 0; i <= k; i++)
        {
            for (int j = k; j < nums.Length; j++)
            {
                if (i != j && nums[i] + nums[j] == target)
                {
                    n[0] = i + 1;
                    n[1] = j + 1;
                    return n;
                }
            }
        }
        return n;
    }
}