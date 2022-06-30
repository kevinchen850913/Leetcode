public class Solution
{
    public int MinMoves2(int[] nums)
    {
        Array.Sort(nums); Array.Sort(nums);
        int sum = 0;
        for (int i = 0; i < nums.Length / 2; i++)
        {
            sum += nums[nums.Length - 1 - i] - nums[i];
        }
        return sum;
    }
}