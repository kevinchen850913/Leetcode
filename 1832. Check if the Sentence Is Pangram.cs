public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        int[] nums = new int[26];
        foreach (var c in sentence)
        {
            nums[c - 'a']++;
        }
        foreach (var n in nums)
        {
            if (n == 0)
                return false;
        }
        return true;
    }
}