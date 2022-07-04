public class Solution
{
    public int Candy(int[] ratings)
    {
        int l = ratings.Length;
        int[] nums = new int[l];
        for (int i = 0; i < l; i++)
        {
            nums[i] = 1;
        }
        for (int i = 1; i < l; i++)
        {
            if (ratings[i - 1] < ratings[i] && nums[i - 1] >= nums[i])
            {
                nums[i] = nums[i - 1] + 1;
            }
            if (ratings[l - i] < ratings[l - i - 1] && nums[l - i] >= nums[l - i - 1])
            {
                nums[l - i - 1] = nums[l - i] + 1;
            }
        }
        int n = 0;
        for (int i = 0; i < l; i++)
        {
            n += nums[i];
        }
        return n;
    }
}