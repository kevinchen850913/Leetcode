public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> MyDic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (MyDic.ContainsKey(nums[i]))
            {
                if (i - MyDic[nums[i]] <= k)
                    return true;
                MyDic[nums[i]] = i;
            }
            else
            {
                MyDic.Add(nums[i], i);
            }
        }
        return false;
    }
}