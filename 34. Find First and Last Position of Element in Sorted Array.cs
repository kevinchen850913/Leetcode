public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        return new int[] { Array.IndexOf(nums, target), Array.LastIndexOf(nums, target) };
    }
}