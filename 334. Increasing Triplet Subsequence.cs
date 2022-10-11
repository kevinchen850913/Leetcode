public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }
        int a = Int32.MaxValue;
        int b = Int32.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > b)
            {
                return true;
            }
            else if (nums[i] < b && nums[i] > a)
            {
                b = nums[i];
            }
            else if (nums[i] < a)
            {
                a = nums[i];
            }
        }
        return false;
    }
}